namespace BasicProject
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIDApp = new MetroFramework.Controls.MetroTextBox();
            this.txtClientSecrec = new MetroFramework.Controls.MetroTextBox();
            this.btnGetTokenApp = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRsAccount = new System.Windows.Forms.RichTextBox();
            this.txtTokenApp = new MetroFramework.Controls.MetroTextBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbSuccess = new MetroFramework.Controls.MetroLabel();
            this.lbFail = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID App:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Client Secrec:";
            // 
            // txtIDApp
            // 
            this.txtIDApp.Location = new System.Drawing.Point(124, 49);
            this.txtIDApp.Name = "txtIDApp";
            this.txtIDApp.Size = new System.Drawing.Size(307, 23);
            this.txtIDApp.TabIndex = 2;
            // 
            // txtClientSecrec
            // 
            this.txtClientSecrec.Location = new System.Drawing.Point(124, 78);
            this.txtClientSecrec.Name = "txtClientSecrec";
            this.txtClientSecrec.Size = new System.Drawing.Size(307, 23);
            this.txtClientSecrec.TabIndex = 3;
            // 
            // btnGetTokenApp
            // 
            this.btnGetTokenApp.Location = new System.Drawing.Point(474, 47);
            this.btnGetTokenApp.Name = "btnGetTokenApp";
            this.btnGetTokenApp.Size = new System.Drawing.Size(121, 23);
            this.btnGetTokenApp.TabIndex = 4;
            this.btnGetTokenApp.Text = "GET TOKEN APP";
            this.btnGetTokenApp.Click += new System.EventHandler(this.btnGetTokenApp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRsAccount);
            this.groupBox1.Location = new System.Drawing.Point(23, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Result";
            // 
            // txtRsAccount
            // 
            this.txtRsAccount.Location = new System.Drawing.Point(3, 19);
            this.txtRsAccount.Name = "txtRsAccount";
            this.txtRsAccount.Size = new System.Drawing.Size(894, 230);
            this.txtRsAccount.TabIndex = 0;
            this.txtRsAccount.Text = "";
            // 
            // txtTokenApp
            // 
            this.txtTokenApp.Location = new System.Drawing.Point(124, 107);
            this.txtTokenApp.Multiline = true;
            this.txtTokenApp.Name = "txtTokenApp";
            this.txtTokenApp.Size = new System.Drawing.Size(307, 25);
            this.txtTokenApp.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(474, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 400);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Thành công: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(275, 400);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Thất bại: ";
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Location = new System.Drawing.Point(113, 400);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(16, 19);
            this.lbSuccess.TabIndex = 10;
            this.lbSuccess.Text = "0";
            // 
            // lbFail
            // 
            this.lbFail.AutoSize = true;
            this.lbFail.Location = new System.Drawing.Point(344, 400);
            this.lbFail.Name = "lbFail";
            this.lbFail.Size = new System.Drawing.Size(16, 19);
            this.lbFail.TabIndex = 11;
            this.lbFail.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 113);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Token App:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(474, 119);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(26, 13);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "Bug";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 426);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtTokenApp);
            this.Controls.Add(this.lbFail);
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetTokenApp);
            this.Controls.Add(this.txtClientSecrec);
            this.Controls.Add(this.txtIDApp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIDApp;
        private MetroFramework.Controls.MetroTextBox txtClientSecrec;
        private MetroFramework.Controls.MetroButton btnGetTokenApp;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtTokenApp;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbSuccess;
        private MetroFramework.Controls.MetroLabel lbFail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.RichTextBox txtRsAccount;
        private System.Windows.Forms.Label lbError;
    }
}

