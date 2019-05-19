namespace Food_Manaer
{
    partial class BookingOfflineForm
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
            this.panelData = new System.Windows.Forms.Panel();
            this.dtgvBookingOffline = new System.Windows.Forms.DataGridView();
            this.panelOption = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAddFloor = new System.Windows.Forms.TextBox();
            this.txtAddNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBookingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFloorID = new System.Windows.Forms.TextBox();
            this.txtBoxTableID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.rBtnUnSuccess = new System.Windows.Forms.RadioButton();
            this.rBtnSuccess = new System.Windows.Forms.RadioButton();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingOffline)).BeginInit();
            this.panelOption.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dtgvBookingOffline);
            this.panelData.Location = new System.Drawing.Point(12, 12);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(546, 342);
            this.panelData.TabIndex = 0;
            // 
            // dtgvBookingOffline
            // 
            this.dtgvBookingOffline.AllowUserToAddRows = false;
            this.dtgvBookingOffline.AllowUserToDeleteRows = false;
            this.dtgvBookingOffline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBookingOffline.Location = new System.Drawing.Point(3, 3);
            this.dtgvBookingOffline.MultiSelect = false;
            this.dtgvBookingOffline.Name = "dtgvBookingOffline";
            this.dtgvBookingOffline.ReadOnly = true;
            this.dtgvBookingOffline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBookingOffline.Size = new System.Drawing.Size(540, 339);
            this.dtgvBookingOffline.TabIndex = 1;
            this.dtgvBookingOffline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBookingOffline_CellClick);
            this.dtgvBookingOffline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvBookingOffline_MouseClick);
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.groupBox3);
            this.panelOption.Controls.Add(this.groupBox2);
            this.panelOption.Controls.Add(this.groupBox1);
            this.panelOption.Location = new System.Drawing.Point(564, 15);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(300, 339);
            this.panelOption.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddFloor);
            this.groupBox3.Controls.Add(this.txtAddNumber);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(3, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm";
            // 
            // txtAddFloor
            // 
            this.txtAddFloor.Location = new System.Drawing.Point(205, 84);
            this.txtAddFloor.Name = "txtAddFloor";
            this.txtAddFloor.Size = new System.Drawing.Size(83, 20);
            this.txtAddFloor.TabIndex = 22;
            this.txtAddFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(205, 37);
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(83, 20);
            this.txtAddNumber.TabIndex = 16;
            this.txtAddNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số lượng người";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tầng số";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 69);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxBookingID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBoxFloorID);
            this.groupBox2.Controls.Add(this.txtBoxTableID);
            this.groupBox2.Location = new System.Drawing.Point(0, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 164);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tim kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bàn số";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 69);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "TÌM KIẾM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tầng số";
            // 
            // txtBoxBookingID
            // 
            this.txtBoxBookingID.Location = new System.Drawing.Point(199, 39);
            this.txtBoxBookingID.Name = "txtBoxBookingID";
            this.txtBoxBookingID.Size = new System.Drawing.Size(83, 20);
            this.txtBoxBookingID.TabIndex = 15;
            this.txtBoxBookingID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã số lần đặt bàn";
            // 
            // txtBoxFloorID
            // 
            this.txtBoxFloorID.Location = new System.Drawing.Point(199, 86);
            this.txtBoxFloorID.Name = "txtBoxFloorID";
            this.txtBoxFloorID.Size = new System.Drawing.Size(83, 20);
            this.txtBoxFloorID.TabIndex = 16;
            this.txtBoxFloorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtBoxTableID
            // 
            this.txtBoxTableID.Location = new System.Drawing.Point(199, 128);
            this.txtBoxTableID.Name = "txtBoxTableID";
            this.txtBoxTableID.Size = new System.Drawing.Size(83, 20);
            this.txtBoxTableID.TabIndex = 17;
            this.txtBoxTableID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnAll);
            this.groupBox1.Controls.Add(this.rBtnUnSuccess);
            this.groupBox1.Controls.Add(this.rBtnSuccess);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Checked = true;
            this.rBtnAll.Location = new System.Drawing.Point(6, 19);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(56, 17);
            this.rBtnAll.TabIndex = 0;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "Tất cả";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // rBtnUnSuccess
            // 
            this.rBtnUnSuccess.AutoSize = true;
            this.rBtnUnSuccess.Location = new System.Drawing.Point(149, 19);
            this.rBtnUnSuccess.Name = "rBtnUnSuccess";
            this.rBtnUnSuccess.Size = new System.Drawing.Size(74, 17);
            this.rBtnUnSuccess.TabIndex = 3;
            this.rBtnUnSuccess.Text = "Chưa xử lý";
            this.rBtnUnSuccess.UseVisualStyleBackColor = true;
            this.rBtnUnSuccess.CheckedChanged += new System.EventHandler(this.rBtnUnSuccess_CheckedChanged);
            // 
            // rBtnSuccess
            // 
            this.rBtnSuccess.AutoSize = true;
            this.rBtnSuccess.Location = new System.Drawing.Point(80, 19);
            this.rBtnSuccess.Name = "rBtnSuccess";
            this.rBtnSuccess.Size = new System.Drawing.Size(63, 17);
            this.rBtnSuccess.TabIndex = 1;
            this.rBtnSuccess.Text = "Đã xử lý";
            this.rBtnSuccess.UseVisualStyleBackColor = true;
            this.rBtnSuccess.CheckedChanged += new System.EventHandler(this.rBtnSuccess_CheckedChanged);
            // 
            // BookingOfflineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 366);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panelData);
            this.Name = "BookingOfflineForm";
            this.Text = "Danh sách đặt bàn tại chỗ";
            this.Load += new System.EventHandler(this.BookingOfflineForm_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookingOffline)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.RadioButton rBtnUnSuccess;
        private System.Windows.Forms.RadioButton rBtnSuccess;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvBookingOffline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFloorID;
        private System.Windows.Forms.TextBox txtBoxTableID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAddFloor;
        private System.Windows.Forms.TextBox txtAddNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}