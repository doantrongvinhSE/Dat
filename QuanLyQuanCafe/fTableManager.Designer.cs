namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDisCount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(797, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(123, 20);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(171, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(171, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(450, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 304);
            panel2.TabIndex = 0;
            // 
            // lsvBill
            // 
            lsvBill.BackColor = Color.Cyan;
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Dock = DockStyle.Fill;
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(0, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(335, 304);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(450, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 57);
            panel3.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txbTotalPrice.Location = new Point(174, 16);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(87, 25);
            txbTotalPrice.TabIndex = 0;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Center;
            txbTotalPrice.TextChanged += txbTotalPrice_TextChanged;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 30);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(84, 23);
            cbSwitchTable.TabIndex = 8;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = Color.OrangeRed;
            btnSwitchTable.FlatStyle = FlatStyle.Flat;
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(84, 25);
            btnSwitchTable.TabIndex = 7;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDisCount
            // 
            nmDisCount.Location = new Point(93, 30);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(75, 23);
            nmDisCount.TabIndex = 6;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.OrangeRed;
            btnDiscount.FlatStyle = FlatStyle.Flat;
            btnDiscount.Location = new Point(93, 2);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(75, 25);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.OrangeRed;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Location = new Point(267, 2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(61, 52);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(450, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 58);
            panel4.TabIndex = 2;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(282, 20);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(47, 23);
            nmFoodCount.TabIndex = 4;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.OrangeRed;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Location = new Point(201, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 52);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 32);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(192, 23);
            cbFood.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(192, 23);
            cbCategory.TabIndex = 1;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 30);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(432, 428);
            flpTable.TabIndex = 5;
            flpTable.Paint += flpTable_Paint;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(797, 470);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "fTableManager";
            Text = "Phần mềm quản lý quán cafe";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Button btnCheckOut;
        private NumericUpDown nmFoodCount;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDisCount;
        private Button btnDiscount;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}