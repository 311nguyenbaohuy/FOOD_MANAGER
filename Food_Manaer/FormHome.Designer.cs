namespace Food_Manaer
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ImportGoods = new System.Windows.Forms.Button();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btnBookingOff = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Sale);
            this.flowLayoutPanel1.Controls.Add(this.btn_Info);
            this.flowLayoutPanel1.Controls.Add(this.btn_ChangePassword);
            this.flowLayoutPanel1.Controls.Add(this.btn_Exit);
            this.flowLayoutPanel1.Controls.Add(this.btn_ImportGoods);
            this.flowLayoutPanel1.Controls.Add(this.btn_Warehouse);
            this.flowLayoutPanel1.Controls.Add(this.btn_Admin);
            this.flowLayoutPanel1.Controls.Add(this.btnBookingOff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 320);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_Sale
            // 
            this.btn_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sale.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sale.Image")));
            this.btn_Sale.Location = new System.Drawing.Point(3, 3);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(162, 72);
            this.btn_Sale.TabIndex = 0;
            this.btn_Sale.Text = "Bán hàng";
            this.btn_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Image = ((System.Drawing.Image)(resources.GetObject("btn_Info.Image")));
            this.btn_Info.Location = new System.Drawing.Point(171, 3);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(162, 72);
            this.btn_Info.TabIndex = 1;
            this.btn_Info.Text = "Thông tin cá nhân";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangePassword.Image")));
            this.btn_ChangePassword.Location = new System.Drawing.Point(3, 81);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(162, 74);
            this.btn_ChangePassword.TabIndex = 2;
            this.btn_ChangePassword.Text = "Đổi mật khẩu";
            this.btn_ChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(171, 81);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(162, 74);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Đăng xuất ";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ImportGoods
            // 
            this.btn_ImportGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportGoods.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImportGoods.Image")));
            this.btn_ImportGoods.Location = new System.Drawing.Point(3, 161);
            this.btn_ImportGoods.Name = "btn_ImportGoods";
            this.btn_ImportGoods.Size = new System.Drawing.Size(162, 74);
            this.btn_ImportGoods.TabIndex = 4;
            this.btn_ImportGoods.Text = "Nhập hàng";
            this.btn_ImportGoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ImportGoods.UseVisualStyleBackColor = true;
            this.btn_ImportGoods.Click += new System.EventHandler(this.btn_ImportGoods_Click);
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Warehouse.Image = ((System.Drawing.Image)(resources.GetObject("btn_Warehouse.Image")));
            this.btn_Warehouse.Location = new System.Drawing.Point(171, 161);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(162, 74);
            this.btn_Warehouse.TabIndex = 5;
            this.btn_Warehouse.Text = "Kho hàng ";
            this.btn_Warehouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Warehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Warehouse_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Image = ((System.Drawing.Image)(resources.GetObject("btn_Admin.Image")));
            this.btn_Admin.Location = new System.Drawing.Point(3, 241);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(162, 74);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "Quản lý";
            this.btn_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btnBookingOff
            // 
            this.btnBookingOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingOff.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingOff.Image")));
            this.btnBookingOff.Location = new System.Drawing.Point(171, 241);
            this.btnBookingOff.Name = "btnBookingOff";
            this.btnBookingOff.Size = new System.Drawing.Size(162, 74);
            this.btnBookingOff.TabIndex = 7;
            this.btnBookingOff.Text = "Đặt bàn tại chỗ";
            this.btnBookingOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingOff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookingOff.UseVisualStyleBackColor = true;
            this.btnBookingOff.Click += new System.EventHandler(this.btnBookingOff_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 340);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ImportGoods;
        private System.Windows.Forms.Button btn_Warehouse;
        public System.Windows.Forms.Button btn_Admin;
        public System.Windows.Forms.Button btnBookingOff;
    }
}