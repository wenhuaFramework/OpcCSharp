namespace OPCService
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnServer = new System.Windows.Forms.Button();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetGroupPro = new System.Windows.Forms.Button();
            this.txtUpdateRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIsSubscribed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIsActive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGroupDeadband = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroupIsActive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimeStamps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQualities = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWriteTagValue = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnServer);
            this.groupBox1.Controls.Add(this.cmbServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPC服务器";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConnServer
            // 
            this.btnConnServer.Location = new System.Drawing.Point(10, 69);
            this.btnConnServer.Name = "btnConnServer";
            this.btnConnServer.Size = new System.Drawing.Size(299, 54);
            this.btnConnServer.TabIndex = 4;
            this.btnConnServer.Text = "连接";
            this.btnConnServer.UseVisualStyleBackColor = true;
            this.btnConnServer.Click += new System.EventHandler(this.btnConnServer_Click);
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.IntegralHeight = false;
            this.cmbServerName.Location = new System.Drawing.Point(63, 31);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(246, 23);
            this.cmbServerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetGroupPro);
            this.groupBox2.Controls.Add(this.txtUpdateRate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIsSubscribed);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIsActive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGroupDeadband);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGroupIsActive);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "组属性";
            // 
            // btnSetGroupPro
            // 
            this.btnSetGroupPro.Location = new System.Drawing.Point(10, 249);
            this.btnSetGroupPro.Name = "btnSetGroupPro";
            this.btnSetGroupPro.Size = new System.Drawing.Size(299, 82);
            this.btnSetGroupPro.TabIndex = 12;
            this.btnSetGroupPro.Text = "设置";
            this.btnSetGroupPro.UseVisualStyleBackColor = true;
            this.btnSetGroupPro.Click += new System.EventHandler(this.btnSetGroupPro_Click);
            // 
            // txtUpdateRate
            // 
            this.txtUpdateRate.Location = new System.Drawing.Point(134, 186);
            this.txtUpdateRate.Name = "txtUpdateRate";
            this.txtUpdateRate.Size = new System.Drawing.Size(175, 25);
            this.txtUpdateRate.TabIndex = 11;
            this.txtUpdateRate.Text = "250";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "UpdateRate";
            // 
            // txtIsSubscribed
            // 
            this.txtIsSubscribed.Location = new System.Drawing.Point(134, 146);
            this.txtIsSubscribed.Name = "txtIsSubscribed";
            this.txtIsSubscribed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIsSubscribed.Size = new System.Drawing.Size(175, 25);
            this.txtIsSubscribed.TabIndex = 9;
            this.txtIsSubscribed.Text = "true";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "IsSubscribed";
            // 
            // txtIsActive
            // 
            this.txtIsActive.Location = new System.Drawing.Point(134, 107);
            this.txtIsActive.Name = "txtIsActive";
            this.txtIsActive.Size = new System.Drawing.Size(175, 25);
            this.txtIsActive.TabIndex = 7;
            this.txtIsActive.Text = "true";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "IsActice";
            // 
            // txtGroupDeadband
            // 
            this.txtGroupDeadband.Location = new System.Drawing.Point(194, 69);
            this.txtGroupDeadband.Name = "txtGroupDeadband";
            this.txtGroupDeadband.Size = new System.Drawing.Size(115, 25);
            this.txtGroupDeadband.TabIndex = 5;
            this.txtGroupDeadband.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "DefaultGroupDeadband";
            // 
            // txtGroupIsActive
            // 
            this.txtGroupIsActive.Location = new System.Drawing.Point(194, 30);
            this.txtGroupIsActive.Name = "txtGroupIsActive";
            this.txtGroupIsActive.Size = new System.Drawing.Size(115, 25);
            this.txtGroupIsActive.TabIndex = 3;
            this.txtGroupIsActive.Text = "true";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "DefaultGroupIsActive";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimeStamps);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtQualities);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTagValue);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(713, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读取值";
            // 
            // txtTimeStamps
            // 
            this.txtTimeStamps.Location = new System.Drawing.Point(71, 156);
            this.txtTimeStamps.Name = "txtTimeStamps";
            this.txtTimeStamps.Size = new System.Drawing.Size(148, 25);
            this.txtTimeStamps.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "时间戳";
            // 
            // txtQualities
            // 
            this.txtQualities.Location = new System.Drawing.Point(71, 101);
            this.txtQualities.Name = "txtQualities";
            this.txtQualities.Size = new System.Drawing.Size(148, 25);
            this.txtQualities.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "质量";
            // 
            // txtTagValue
            // 
            this.txtTagValue.Location = new System.Drawing.Point(71, 47);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.Size = new System.Drawing.Size(148, 25);
            this.txtTagValue.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tag值";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWrite);
            this.groupBox4.Controls.Add(this.txtWriteTagValue);
            this.groupBox4.Location = new System.Drawing.Point(713, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 248);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "写入值";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(22, 88);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(197, 141);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtWriteTagValue
            // 
            this.txtWriteTagValue.Location = new System.Drawing.Point(22, 38);
            this.txtWriteTagValue.Name = "txtWriteTagValue";
            this.txtWriteTagValue.Size = new System.Drawing.Size(197, 25);
            this.txtWriteTagValue.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(353, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 454);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "总条数：";
            // 
            // lblTagNum
            // 
            this.lblTagNum.AutoSize = true;
            this.lblTagNum.Location = new System.Drawing.Point(449, 485);
            this.lblTagNum.Name = "lblTagNum";
            this.lblTagNum.Size = new System.Drawing.Size(15, 15);
            this.lblTagNum.TabIndex = 6;
            this.lblTagNum.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 520);
            this.Controls.Add(this.lblTagNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnConnServer;
        private System.Windows.Forms.Button btnSetGroupPro;
        private System.Windows.Forms.TextBox txtUpdateRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIsSubscribed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGroupDeadband;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroupIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeStamps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQualities;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTagValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWriteTagValue;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTagNum;
    }
}

