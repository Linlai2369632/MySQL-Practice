using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySqlConnector;


namespace Mysql_test
{
    public partial class Form1 : Form
    {
        private string connectionString = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void pbConnect_Click(object sender, EventArgs e)
        {
            // 建立 Connection String
            // 請根據您本地端的 MySQL 資料庫、帳號與密碼調整
            //connectionString = $"Server={tbHostIP.Text};Database=testdb;User ID={tbUser.Text};Password={tbPassword};";
            connectionString = $"Server={tbHostIP.Text};Database=testdb;User ID={tbUser.Text};Password={tbPassword};SslMode=None;AllowPublicKeyRetrieval=True;";
            connectionString = $"Server=127.0.0.1;Database=testdb;User ID=root;Password=root;SslMode=None;AllowPublicKeyRetrieval=True;";


            using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("成功連線到 MySQL！");

                // 1. 建立資料表 (若不存在，則建立)
                // 注意：這裡 ProductID 為 VARCHAR(50) 為 Primary Key
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS products (
                        ProductID VARCHAR(50) PRIMARY KEY,
                        LongitudeAndLatitude VARCHAR(100),
                        Energy DECIMAL(10,2),
                        Temperature DECIMAL(10,2),
                        Voltage DECIMAL(10,2),
                        Current DECIMAL(10,2),
                        LastUpdateTime DATETIME
                    );
                ";
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("已確認資料表 products (以字串作為 Primary Key) 存在。");
                }
            }
        }

        private void pbUpload_Click(object sender, EventArgs e)
        {
            string newProductID = tbProductID.Text;

            // 2-1. 檢查該 ProductID 是否已存在
            string checkQuery = "SELECT COUNT(*) FROM products WHERE ProductID = @ProductID";

            using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlConnector.MySqlCommand checkCmd = new MySqlConnector.MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductID", newProductID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        Console.WriteLine($"ProductID = {newProductID} 已存在，跳過插入或執行其他處理。");
                    }
                    else
                    {
                        // 2-2. 不存在才執行插入
                        string insertQuery = @"
                            INSERT INTO products (
                                ProductID,
                                LongitudeAndLatitude,
                                Energy,
                                Temperature,
                                Voltage,
                                Current,
                                LastUpdateTime
                            ) VALUES (
                                @ProductID,
                                @LongitudeAndLatitude,
                                @Energy,
                                @Temperature,
                                @Voltage,
                                @Current,
                                @LastUpdateTime
                            );
                        ";

                        using (MySqlConnector.MySqlCommand insertCmd = new MySqlConnector.MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@ProductID", newProductID);
                            insertCmd.Parameters.AddWithValue("@LongitudeAndLatitude", "25.0340,121.5645");
                            insertCmd.Parameters.AddWithValue("@Energy", Convert.ToInt32(tbEnergy.Text));
                            insertCmd.Parameters.AddWithValue("@Temperature", Convert.ToInt32(tbTemperature.Text));
                            insertCmd.Parameters.AddWithValue("@Voltage", Convert.ToInt32(tbVoltage.Text));
                            insertCmd.Parameters.AddWithValue("@Current", Convert.ToInt32(tbCurrent.Text));
                            insertCmd.Parameters.AddWithValue("@LastUpdateTime", DateTime.Now);

                            insertCmd.ExecuteNonQuery();
                            Console.WriteLine($"已成功插入 ProductID = {newProductID} 的資料。");
                        }
                    }
                }
            }

            
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM products"; // 取得所有資料

            using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(selectQuery, conn))
                {
                    using (MySqlConnector.MySqlDataAdapter adapter = new MySqlConnector.MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSQLData.DataSource = dt; // 設定 DataGridView 的資料來源
                    }
                }
            }
        }
    }
}
