namespace Mysql_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHostIP = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.tbLongitudeAndLatitude = new System.Windows.Forms.TextBox();
            this.tbEnergy = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbLastUpdateTime = new System.Windows.Forms.TextBox();
            this.dgvSQLData = new System.Windows.Forms.DataGridView();
            this.pbUpload = new System.Windows.Forms.Button();
            this.pbRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host IP";
            // 
            // tbHostIP
            // 
            this.tbHostIP.Location = new System.Drawing.Point(154, 30);
            this.tbHostIP.Name = "tbHostIP";
            this.tbHostIP.Size = new System.Drawing.Size(198, 35);
            this.tbHostIP.TabIndex = 3;
            this.tbHostIP.Text = "127.0.0.1";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(154, 72);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(198, 35);
            this.tbUser.TabIndex = 4;
            this.tbUser.Text = "root";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(154, 114);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(198, 35);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "root";
            // 
            // pbConnect
            // 
            this.pbConnect.Location = new System.Drawing.Point(389, 66);
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(123, 44);
            this.pbConnect.TabIndex = 6;
            this.pbConnect.Text = "Connect";
            this.pbConnect.UseVisualStyleBackColor = true;
            this.pbConnect.Click += new System.EventHandler(this.pbConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProductID (Primary key)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "LongitudeAndLatitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Energy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Voltage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Current";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 27);
            this.label10.TabIndex = 13;
            this.label10.Text = "LastUpdateTime";
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(282, 182);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(198, 35);
            this.tbProductID.TabIndex = 14;
            this.tbProductID.Text = "ICPDAS00001";
            // 
            // tbLongitudeAndLatitude
            // 
            this.tbLongitudeAndLatitude.Location = new System.Drawing.Point(282, 225);
            this.tbLongitudeAndLatitude.Name = "tbLongitudeAndLatitude";
            this.tbLongitudeAndLatitude.Size = new System.Drawing.Size(198, 35);
            this.tbLongitudeAndLatitude.TabIndex = 15;
            this.tbLongitudeAndLatitude.Text = "25.0340,121.5645";
            // 
            // tbEnergy
            // 
            this.tbEnergy.Location = new System.Drawing.Point(282, 274);
            this.tbEnergy.Name = "tbEnergy";
            this.tbEnergy.Size = new System.Drawing.Size(198, 35);
            this.tbEnergy.TabIndex = 16;
            this.tbEnergy.Text = "100";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(282, 324);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(198, 35);
            this.tbTemperature.TabIndex = 17;
            this.tbTemperature.Text = "25";
            // 
            // tbVoltage
            // 
            this.tbVoltage.Location = new System.Drawing.Point(282, 375);
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Size = new System.Drawing.Size(198, 35);
            this.tbVoltage.TabIndex = 18;
            this.tbVoltage.Text = "5";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(282, 426);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(198, 35);
            this.tbCurrent.TabIndex = 19;
            this.tbCurrent.Text = "150";
            // 
            // tbLastUpdateTime
            // 
            this.tbLastUpdateTime.Enabled = false;
            this.tbLastUpdateTime.Location = new System.Drawing.Point(282, 482);
            this.tbLastUpdateTime.Name = "tbLastUpdateTime";
            this.tbLastUpdateTime.Size = new System.Drawing.Size(198, 35);
            this.tbLastUpdateTime.TabIndex = 20;
            // 
            // dgvSQLData
            // 
            this.dgvSQLData.AllowUserToAddRows = false;
            this.dgvSQLData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSQLData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLData.Location = new System.Drawing.Point(542, 30);
            this.dgvSQLData.Name = "dgvSQLData";
            this.dgvSQLData.RowHeadersWidth = 51;
            this.dgvSQLData.RowTemplate.Height = 27;
            this.dgvSQLData.Size = new System.Drawing.Size(738, 487);
            this.dgvSQLData.TabIndex = 21;
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(357, 530);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(123, 44);
            this.pbUpload.TabIndex = 22;
            this.pbUpload.Text = "Upload";
            this.pbUpload.UseVisualStyleBackColor = true;
            this.pbUpload.Click += new System.EventHandler(this.pbUpload_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Location = new System.Drawing.Point(1157, 530);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(123, 44);
            this.pbRefresh.TabIndex = 23;
            this.pbRefresh.Text = "Refresh";
            this.pbRefresh.UseVisualStyleBackColor = true;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 586);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.dgvSQLData);
            this.Controls.Add(this.tbLastUpdateTime);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.tbVoltage);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbEnergy);
            this.Controls.Add(this.tbLongitudeAndLatitude);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbConnect);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHostIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHostIP;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button pbConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.TextBox tbLongitudeAndLatitude;
        private System.Windows.Forms.TextBox tbEnergy;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbVoltage;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbLastUpdateTime;
        private System.Windows.Forms.DataGridView dgvSQLData;
        private System.Windows.Forms.Button pbUpload;
        private System.Windows.Forms.Button pbRefresh;
    }
}

