namespace Food_Manaer
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseInfo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txbCountry = new System.Windows.Forms.TextBox();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.pblSex = new System.Windows.Forms.Panel();
            this.rdbWomen = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pblSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseInfo);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txbCountry);
            this.panel1.Controls.Add(this.txbTelephone);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.pblSex);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 304);
            this.panel1.TabIndex = 3;
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInfo.Location = new System.Drawing.Point(296, 266);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(83, 25);
            this.btnCloseInfo.TabIndex = 4;
            this.btnCloseInfo.Text = "Đóng";
            this.btnCloseInfo.UseVisualStyleBackColor = true;
            this.btnCloseInfo.Click += new System.EventHandler(this.btnCloseInfo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(187, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 25);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Cập nhập";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txbCountry
            // 
            this.txbCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCountry.Location = new System.Drawing.Point(133, 194);
            this.txbCountry.Multiline = true;
            this.txbCountry.Name = "txbCountry";
            this.txbCountry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCountry.Size = new System.Drawing.Size(246, 52);
            this.txbCountry.TabIndex = 11;
            this.txbCountry.TextChanged += new System.EventHandler(this.txbCountry_TextChanged);
            // 
            // txbTelephone
            // 
            this.txbTelephone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelephone.Location = new System.Drawing.Point(133, 148);
            this.txbTelephone.Multiline = true;
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(246, 25);
            this.txbTelephone.TabIndex = 10;
            this.txbTelephone.TextChanged += new System.EventHandler(this.txbTelephone_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(133, 99);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(246, 25);
            this.txbEmail.TabIndex = 9;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // pblSex
            // 
            this.pblSex.Controls.Add(this.rdbWomen);
            this.pblSex.Controls.Add(this.rdbMan);
            this.pblSex.Location = new System.Drawing.Point(133, 48);
            this.pblSex.Name = "pblSex";
            this.pblSex.Size = new System.Drawing.Size(270, 29);
            this.pblSex.TabIndex = 8;
            // 
            // rdbWomen
            // 
            this.rdbWomen.AutoSize = true;
            this.rdbWomen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWomen.Location = new System.Drawing.Point(82, 5);
            this.rdbWomen.Name = "rdbWomen";
            this.rdbWomen.Size = new System.Drawing.Size(46, 21);
            this.rdbWomen.TabIndex = 9;
            this.rdbWomen.TabStop = true;
            this.rdbWomen.Text = "Nữ";
            this.rdbWomen.UseVisualStyleBackColor = true;
            this.rdbWomen.CheckedChanged += new System.EventHandler(this.rdbWomen_CheckedChanged);
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMan.Location = new System.Drawing.Point(3, 5);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(57, 21);
            this.rdbMan.TabIndex = 0;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "Nam";
            this.rdbMan.UseVisualStyleBackColor = true;
            this.rdbMan.CheckedChanged += new System.EventHandler(this.rdbMan_CheckedChanged);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(133, 9);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(246, 25);
            this.txbName.TabIndex = 6;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // FormInfo
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCloseInfo;
            this.ClientSize = new System.Drawing.Size(447, 328);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInfo_FormClosing);
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pblSex.ResumeLayout(false);
            this.pblSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txbCountry;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Panel pblSex;
        private System.Windows.Forms.RadioButton rdbWomen;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}