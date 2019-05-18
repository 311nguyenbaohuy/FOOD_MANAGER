namespace Food_Manaer
{
    partial class FormSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.gb = new System.Windows.Forms.GroupBox();
            this.flpTableFood = new System.Windows.Forms.FlowLayoutPanel();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.txbSumMoney = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.nudSale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDish = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDrink = new System.Windows.Forms.RadioButton();
            this.rdbFood = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDish = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbBill = new System.Windows.Forms.GroupBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.gbDeleteDish = new System.Windows.Forms.GroupBox();
            this.nudNumber1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.cbDish1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMoveTable = new System.Windows.Forms.GroupBox();
            this.btnMoveTable = new System.Windows.Forms.Button();
            this.cbTable1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.gbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSale)).BeginInit();
            this.gbDish.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.gbBill.SuspendLayout();
            this.gbDeleteDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber1)).BeginInit();
            this.gbMoveTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.flpTableFood);
            this.gb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(24, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(514, 510);
            this.gb.TabIndex = 2;
            this.gb.TabStop = false;
            this.gb.Text = "Danh sách bàn ăn";
            // 
            // flpTableFood
            // 
            this.flpTableFood.AutoScroll = true;
            this.flpTableFood.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTableFood.Location = new System.Drawing.Point(6, 27);
            this.flpTableFood.Name = "flpTableFood";
            this.flpTableFood.Size = new System.Drawing.Size(492, 486);
            this.flpTableFood.TabIndex = 0;
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.txbSumMoney);
            this.gbTable.Controls.Add(this.btnPay);
            this.gbTable.Controls.Add(this.nudSale);
            this.gbTable.Controls.Add(this.label2);
            this.gbTable.Controls.Add(this.label1);
            this.gbTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTable.Location = new System.Drawing.Point(554, 12);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(486, 87);
            this.gbTable.TabIndex = 3;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Chi tiết bàn ăn";
            // 
            // txbSumMoney
            // 
            this.txbSumMoney.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSumMoney.Location = new System.Drawing.Point(84, 27);
            this.txbSumMoney.Multiline = true;
            this.txbSumMoney.Name = "txbSumMoney";
            this.txbSumMoney.Size = new System.Drawing.Size(85, 21);
            this.txbSumMoney.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(379, 21);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(101, 30);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // nudSale
            // 
            this.nudSale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSale.Location = new System.Drawing.Point(290, 26);
            this.nudSale.Name = "nudSale";
            this.nudSale.Size = new System.Drawing.Size(76, 22);
            this.nudSale.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khuyến mãi(%): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền: ";
            // 
            // gbDish
            // 
            this.gbDish.Controls.Add(this.panel1);
            this.gbDish.Controls.Add(this.label6);
            this.gbDish.Controls.Add(this.btnAddDish);
            this.gbDish.Controls.Add(this.nudNumber);
            this.gbDish.Controls.Add(this.label5);
            this.gbDish.Controls.Add(this.cbDish);
            this.gbDish.Controls.Add(this.label4);
            this.gbDish.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDish.Location = new System.Drawing.Point(554, 105);
            this.gbDish.Name = "gbDish";
            this.gbDish.Size = new System.Drawing.Size(488, 91);
            this.gbDish.TabIndex = 5;
            this.gbDish.TabStop = false;
            this.gbDish.Text = "Gọi món";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdbDrink);
            this.panel1.Controls.Add(this.rdbFood);
            this.panel1.Location = new System.Drawing.Point(85, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 31);
            this.panel1.TabIndex = 6;
            // 
            // rdbDrink
            // 
            this.rdbDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDrink.AutoSize = true;
            this.rdbDrink.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDrink.Location = new System.Drawing.Point(92, 3);
            this.rdbDrink.Name = "rdbDrink";
            this.rdbDrink.Size = new System.Drawing.Size(100, 21);
            this.rdbDrink.TabIndex = 1;
            this.rdbDrink.TabStop = true;
            this.rdbDrink.Text = "Nước uống";
            this.rdbDrink.UseVisualStyleBackColor = true;
            this.rdbDrink.CheckedChanged += new System.EventHandler(this.rdbDrink_CheckedChanged);
            // 
            // rdbFood
            // 
            this.rdbFood.AutoSize = true;
            this.rdbFood.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFood.Location = new System.Drawing.Point(7, 3);
            this.rdbFood.Name = "rdbFood";
            this.rdbFood.Size = new System.Drawing.Size(65, 21);
            this.rdbFood.TabIndex = 0;
            this.rdbFood.TabStop = true;
            this.rdbFood.Text = "Đồ ăn";
            this.rdbFood.UseVisualStyleBackColor = true;
            this.rdbFood.CheckedChanged += new System.EventHandler(this.rdbFood_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chọn loại:";
            // 
            // btnAddDish
            // 
            this.btnAddDish.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.Location = new System.Drawing.Point(331, 57);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(95, 30);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(370, 26);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(76, 22);
            this.nudNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng:";
            // 
            // cbDish
            // 
            this.cbDish.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDish.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDish.DropDownHeight = 100;
            this.cbDish.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDish.FormattingEnabled = true;
            this.cbDish.IntegralHeight = false;
            this.cbDish.Location = new System.Drawing.Point(92, 63);
            this.cbDish.Name = "cbDish";
            this.cbDish.Size = new System.Drawing.Size(180, 24);
            this.cbDish.TabIndex = 1;
            this.cbDish.SelectedValueChanged += new System.EventHandler(this.cbDish_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn món:";
            // 
            // gbBill
            // 
            this.gbBill.Controls.Add(this.lvBill);
            this.gbBill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBill.Location = new System.Drawing.Point(554, 202);
            this.gbBill.Name = "gbBill";
            this.gbBill.Size = new System.Drawing.Size(487, 212);
            this.gbBill.TabIndex = 6;
            this.gbBill.TabStop = false;
            this.gbBill.Text = "Hóa đơn";
            // 
            // lvBill
            // 
            this.lvBill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.FullRowSelect = true;
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(6, 21);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(473, 185);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // gbDeleteDish
            // 
            this.gbDeleteDish.Controls.Add(this.nudNumber1);
            this.gbDeleteDish.Controls.Add(this.label8);
            this.gbDeleteDish.Controls.Add(this.btnDeleteDish);
            this.gbDeleteDish.Controls.Add(this.cbDish1);
            this.gbDeleteDish.Controls.Add(this.label7);
            this.gbDeleteDish.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeleteDish.Location = new System.Drawing.Point(554, 420);
            this.gbDeleteDish.Name = "gbDeleteDish";
            this.gbDeleteDish.Size = new System.Drawing.Size(277, 109);
            this.gbDeleteDish.TabIndex = 8;
            this.gbDeleteDish.TabStop = false;
            this.gbDeleteDish.Text = "Trả món";
            // 
            // nudNumber1
            // 
            this.nudNumber1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber1.Location = new System.Drawing.Point(85, 69);
            this.nudNumber1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber1.Name = "nudNumber1";
            this.nudNumber1.Size = new System.Drawing.Size(76, 22);
            this.nudNumber1.TabIndex = 7;
            this.nudNumber1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng:";
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDish.Location = new System.Drawing.Point(176, 61);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(95, 34);
            this.btnDeleteDish.TabIndex = 5;
            this.btnDeleteDish.Text = "Trả món";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // cbDish1
            // 
            this.cbDish1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDish1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDish1.DropDownHeight = 100;
            this.cbDish1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDish1.FormattingEnabled = true;
            this.cbDish1.IntegralHeight = false;
            this.cbDish1.Location = new System.Drawing.Point(86, 27);
            this.cbDish1.Name = "cbDish1";
            this.cbDish1.Size = new System.Drawing.Size(185, 24);
            this.cbDish1.TabIndex = 2;
            this.cbDish1.SelectedIndexChanged += new System.EventHandler(this.cbDish1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn món:";
            // 
            // gbMoveTable
            // 
            this.gbMoveTable.Controls.Add(this.btnMoveTable);
            this.gbMoveTable.Controls.Add(this.cbTable1);
            this.gbMoveTable.Controls.Add(this.label3);
            this.gbMoveTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMoveTable.Location = new System.Drawing.Point(848, 420);
            this.gbMoveTable.Name = "gbMoveTable";
            this.gbMoveTable.Size = new System.Drawing.Size(196, 109);
            this.gbMoveTable.TabIndex = 9;
            this.gbMoveTable.TabStop = false;
            this.gbMoveTable.Text = "Chuyển bàn";
            // 
            // btnMoveTable
            // 
            this.btnMoveTable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveTable.Location = new System.Drawing.Point(41, 61);
            this.btnMoveTable.Name = "btnMoveTable";
            this.btnMoveTable.Size = new System.Drawing.Size(95, 34);
            this.btnMoveTable.TabIndex = 5;
            this.btnMoveTable.Text = "Chuyển bàn";
            this.btnMoveTable.UseVisualStyleBackColor = true;
            this.btnMoveTable.Click += new System.EventHandler(this.btnMoveTable_Click);
            // 
            // cbTable1
            // 
            this.cbTable1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTable1.DropDownHeight = 100;
            this.cbTable1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTable1.FormattingEnabled = true;
            this.cbTable1.IntegralHeight = false;
            this.cbTable1.Location = new System.Drawing.Point(91, 27);
            this.cbTable1.Name = "cbTable1";
            this.cbTable1.Size = new System.Drawing.Size(97, 24);
            this.cbTable1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn bàn:";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1055, 537);
            this.Controls.Add(this.gbMoveTable);
            this.Controls.Add(this.gbDeleteDish);
            this.Controls.Add(this.gbBill);
            this.Controls.Add(this.gbDish);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.gb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSale";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.gb.ResumeLayout(false);
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSale)).EndInit();
            this.gbDish.ResumeLayout(false);
            this.gbDish.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.gbBill.ResumeLayout(false);
            this.gbDeleteDish.ResumeLayout(false);
            this.gbDeleteDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber1)).EndInit();
            this.gbMoveTable.ResumeLayout(false);
            this.gbMoveTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.FlowLayoutPanel flpTableFood;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.TextBox txbSumMoney;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.NumericUpDown nudSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDrink;
        private System.Windows.Forms.RadioButton rdbFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbBill;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.GroupBox gbDeleteDish;
        private System.Windows.Forms.NumericUpDown nudNumber1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.ComboBox cbDish1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbMoveTable;
        private System.Windows.Forms.Button btnMoveTable;
        private System.Windows.Forms.ComboBox cbTable1;
        private System.Windows.Forms.Label label3;
    }
}