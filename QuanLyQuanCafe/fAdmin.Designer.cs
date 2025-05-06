namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            cbbTable = new ComboBox();
            cbbTypeStatistics = new ComboBox();
            btnViewbill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpAccount = new TabPage();
            btnResetPassword = new Button();
            panel21 = new Panel();
            numericUpDown2 = new NumericUpDown();
            label12 = new Label();
            panel22 = new Panel();
            txbDisplayName = new TextBox();
            label13 = new Label();
            panel23 = new Panel();
            txbUserName = new TextBox();
            label14 = new Label();
            panel25 = new Panel();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel26 = new Panel();
            dtgvAccount = new DataGridView();
            tabPage1 = new TabPage();
            saveFileDialog1 = new SaveFileDialog();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpAccount.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Controls.Add(tabPage1);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(776, 426);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpBill
            // 
            tpBill.BackColor = Color.FromArgb(255, 192, 128);
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.ForeColor = SystemColors.ActiveCaptionText;
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(768, 398);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbbTable);
            panel2.Controls.Add(cbbTypeStatistics);
            panel2.Controls.Add(btnViewbill);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 31);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // cbbTable
            // 
            cbbTable.FormattingEnabled = true;
            cbbTable.Location = new Point(353, 3);
            cbbTable.Name = "cbbTable";
            cbbTable.Size = new Size(108, 23);
            cbbTable.TabIndex = 6;
            // 
            // cbbTypeStatistics
            // 
            cbbTypeStatistics.FormattingEnabled = true;
            cbbTypeStatistics.Items.AddRange(new object[] { "None", "Thống Kê Theo Bàn", "Thống Kê Theo Món" });
            cbbTypeStatistics.Location = new Point(209, 3);
            cbbTypeStatistics.Name = "cbbTypeStatistics";
            cbbTypeStatistics.Size = new Size(138, 23);
            cbbTypeStatistics.TabIndex = 5;
            cbbTypeStatistics.Text = "Kiểu thống kê";
            cbbTypeStatistics.SelectedIndexChanged += cbbTypeStatistics_SelectedIndexChanged;
            // 
            // btnViewbill
            // 
            btnViewbill.Location = new Point(467, 3);
            btnViewbill.Name = "btnViewbill";
            btnViewbill.Size = new Size(75, 23);
            btnViewbill.TabIndex = 4;
            btnViewbill.Text = "Thống kê";
            btnViewbill.UseVisualStyleBackColor = true;
            btnViewbill.Click += btnViewbill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(558, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 3;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 349);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.BackgroundColor = SystemColors.ScrollBar;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(0, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.Size = new Size(762, 343);
            dtgvBill.TabIndex = 1;
            // 
            // tpFood
            // 
            tpFood.BackColor = Color.FromArgb(255, 192, 128);
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(768, 398);
            tpFood.TabIndex = 1;
            tpFood.Text = "Nước uống";
            tpFood.Click += tpFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(461, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 50);
            panel6.TabIndex = 1;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(13, 15);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(205, 23);
            txbSearchFoodName.TabIndex = 6;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(223, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(75, 44);
            btnSearchFood.TabIndex = 5;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(461, 62);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 330);
            panel5.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 145);
            panel10.Name = "panel10";
            panel10.Size = new Size(295, 41);
            panel10.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(74, 10);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(208, 23);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 12);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 0;
            label4.Text = "Giá";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 97);
            panel9.Name = "panel9";
            panel9.Size = new Size(295, 41);
            panel9.TabIndex = 2;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(74, 9);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(207, 23);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 12);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Danh mục";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(4, 50);
            panel8.Name = "panel8";
            panel8.Size = new Size(295, 41);
            panel8.TabIndex = 1;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(73, 9);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(208, 23);
            txbFoodName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên món";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 41);
            panel7.TabIndex = 0;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(74, 9);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(207, 23);
            txbFoodID.TabIndex = 7;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 50);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(349, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(75, 44);
            btnShowFood.TabIndex = 4;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(240, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(75, 44);
            btnEditFood.TabIndex = 3;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(120, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(75, 44);
            btnDeleteFood.TabIndex = 2;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 44);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 330);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 12);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.Size = new Size(443, 315);
            dtgvFood.TabIndex = 0;
            dtgvFood.CellContentClick += dtgvFood_CellContentClick;
            // 
            // tpAccount
            // 
            tpAccount.BackColor = Color.FromArgb(255, 192, 128);
            tpAccount.Controls.Add(btnResetPassword);
            tpAccount.Controls.Add(panel21);
            tpAccount.Controls.Add(panel22);
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel25);
            tpAccount.Controls.Add(panel26);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Size = new Size(768, 398);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(689, 206);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(75, 44);
            btnResetPassword.TabIndex = 10;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel21
            // 
            panel21.Controls.Add(numericUpDown2);
            panel21.Controls.Add(label12);
            panel21.Location = new Point(463, 159);
            panel21.Name = "panel21";
            panel21.Size = new Size(301, 41);
            panel21.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(97, 10);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(36, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 12);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 0;
            label12.Text = "Loại tài khoản";
            // 
            // panel22
            // 
            panel22.Controls.Add(txbDisplayName);
            panel22.Controls.Add(label13);
            panel22.Location = new Point(463, 108);
            panel22.Name = "panel22";
            panel22.Size = new Size(301, 41);
            panel22.TabIndex = 7;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(94, 9);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(204, 23);
            txbDisplayName.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 12);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 0;
            label13.Text = "Tên hiển thị";
            // 
            // panel23
            // 
            panel23.Controls.Add(txbUserName);
            panel23.Controls.Add(label14);
            panel23.Location = new Point(463, 64);
            panel23.Name = "panel23";
            panel23.Size = new Size(302, 41);
            panel23.TabIndex = 4;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(94, 9);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(205, 23);
            txbUserName.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 12);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 0;
            label14.Text = "Tên tài khoản";
            // 
            // panel25
            // 
            panel25.Controls.Add(btnEditAccount);
            panel25.Controls.Add(btnDeleteAccount);
            panel25.Controls.Add(btnAddAccount);
            panel25.Location = new Point(9, 8);
            panel25.Name = "panel25";
            panel25.Size = new Size(449, 50);
            panel25.TabIndex = 5;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(315, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(75, 44);
            btnEditAccount.TabIndex = 3;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(171, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 44);
            btnDeleteAccount.TabIndex = 2;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(75, 44);
            btnAddAccount.TabIndex = 1;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel26
            // 
            panel26.Controls.Add(dtgvAccount);
            panel26.Location = new Point(9, 64);
            panel26.Name = "panel26";
            panel26.Size = new Size(449, 330);
            panel26.TabIndex = 6;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.Size = new Size(443, 324);
            dtgvAccount.TabIndex = 0;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Report";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(tcAdmin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpAccount.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel25.ResumeLayout(false);
            panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpAccount;
        private Panel panel2;
        private Button btnViewbill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private ComboBox cbFoodCategory;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
        private Button button1;
        private Panel panel20;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Panel panel21;
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel22;
        private TextBox txbDisplayName;
        private Label label13;
        private Panel panel23;
        private TextBox txbUserName;
        private Label label14;
        private Panel panel25;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button button5;
        private Panel panel26;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private System.Windows.Forms.Button btnAddAccount;
        private NumericUpDown numericUpDown2;
        private SaveFileDialog saveFileDialog1;
        private TabPage tabPage1;
        private ComboBox cbbTypeStatistics;
        private ComboBox cbbTable;
    }
}