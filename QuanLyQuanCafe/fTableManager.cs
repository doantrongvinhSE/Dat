using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DTO;
using System.Globalization;


namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }


        public fTableManager(Account acc)
        {
            //Check neu acc login = k0 thi bat Type = 1 len
            if(acc.UserName == "K9")
                acc.Type = 1;

            InitializeComponent();
            this.LoginAccount = acc;

            //Doan nay
            ChangeAccount(LoginAccount.Type);

            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }

        #region Method

        void ChangeAccount(int type)
        {
            //Y NGHIA CUA DOAN NAY LA NEU TYPE = 1 THI adminToolStripMenuItem DC ENABLE
            adminToolStripMenuItem.Enabled = type == 1;
        }





        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);

            if (listFood == null || listFood.Count == 0)
            {
                MessageBox.Show("Không có món ăn trong danh mục này.");
                return; 
            }

            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }


        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua; 
                        break;
                    default:
                        btn.BackColor = Color.Yellow; 
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int tableID)
        {
            lsvBill.Items.Clear();

            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTableID(tableID);
            float totalPrice = 0;

            CultureInfo culture = new CultureInfo("vi-VN");

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,##0", culture) + " ₫");
                lsvItem.SubItems.Add(item.TotalPrice.ToString("#,##0", culture) + " ₫");

                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }

            txbTotalPrice.Text = totalPrice.ToString("#,##0", culture) + " ₫";
        }






        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }


        #endregion


        #region Events

        private Button currentSelectedTableButton = null;


        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);

            if (currentSelectedTableButton != null)
            {
                Table oldTable = currentSelectedTableButton.Tag as Table;
                if (oldTable.Status == "Trống")
                    currentSelectedTableButton.BackColor = Color.Aqua;
                else
                    currentSelectedTableButton.BackColor = Color.Yellow;
            }

            currentSelectedTableButton = sender as Button;
            currentSelectedTableButton.BackColor = Color.Orange;
        }




        private void fTableManager_Load(object sender, EventArgs e)
        {
            ChangeAccount(LoginAccount.Type);
        }


        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object? sender, AccountEvent e)
        {
            if (e?.Acc != null)
            {
                thôngTinTàiKhoảnToolStripMenuItem.Text = $"Thông tin tài khoản ({e.Acc.DisplayName})";
            }
        }



        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount; 
            f.ShowDialog();

        }



        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += f_InsertFood;
            f.DeleteFood += f_DeleteFood;
            f.UpdateFood += f_UpdateFood;
            f.ShowDialog();
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa chọn danh mục trong cbCategory
            var selectedCategory = cbCategory.SelectedItem as Category;
            if (selectedCategory == null)
            {
                MessageBox.Show("Vui lòng chọn một danh mục.");
                return; // Dừng lại nếu chưa có danh mục được chọn
            }

            // Kiểm tra xem danh mục có ID hợp lệ không
            // Nếu ID là int, chỉ cần kiểm tra ID == 0, nếu là int?, kiểm tra null và 0.
            if (selectedCategory.ID == 0)
            {
                MessageBox.Show("Danh mục không hợp lệ.");
                return; // Dừng lại nếu danh mục không hợp lệ
            }

            // Thêm thông báo log để kiểm tra đối tượng Category
            MessageBox.Show($"Đang xử lý danh mục có ID: {selectedCategory.ID}");

            try
            {
                // Kiểm tra và gọi LoadFoodListByCategoryID
                LoadFoodListByCategoryID(selectedCategory.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}");
                return; // Dừng lại nếu có lỗi khi tải danh sách món ăn
            }

            // Kiểm tra nếu lsvBill.Tag có đối tượng hợp lệ
            if (lsvBill.Tag != null)
            {
                var table = lsvBill.Tag as Table;
                if (table != null)
                {
                    // Thêm thông báo log để kiểm tra đối tượng Table
                    MessageBox.Show($"Đang xử lý bàn có ID: {table.ID}");

                    // Gọi ShowBill nếu table hợp lệ
                    try
                    {
                        ShowBill(table.ID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi hiển thị hóa đơn: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: lsvBill.Tag không phải là một đối tượng Table hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Lỗi: lsvBill.Tag là null.");
            }
        }






        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
            ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
            ShowBill((lsvBill.Tag as Table).ID);
        }


        #endregion

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox)?.SelectedItem is Category selected)
            {
                int id = selected.ID;
                LoadFoodListByCategoryID(id);
            }
        }



        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra bàn
            if (lsvBill.Tag is not Table table)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra món ăn
            if (cbFood.SelectedItem is not Food selectedFood)
            {
                MessageBox.Show("Vui lòng chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foodID = selectedFood.ID;
            int count = (int)nmFoodCount.Value;

            int? idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

            if (idBill == null)
            {
                BillDAO.Instance.InsertBill(table.ID); // tạo bill mới
                int newBillID = BillDAO.Instance.GetMaxIDBill(); // lấy id bill mới tạo
                BillInfoDAO.Instance.InsertBillInfo(newBillID, foodID, count); // thêm món
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill.Value, foodID, count); // bill đã có, chỉ thêm món
            }

            ShowBill(table.ID);

            LoadTable();
        }



        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Bàn không hợp lệ.", "Thông báo", MessageBoxButtons.OK);
                return; 
            }

            int? idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            // Sửa lỗi parse tiền tệ
            string raw = txbTotalPrice.Text.Split('₫')[0].Trim().Replace(".", "");
            double totalPrice = double.Parse(raw);

            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (!idBill.HasValue || idBill.Value == -1)
            {
                MessageBox.Show("Không có hóa đơn chưa thanh toán cho bàn này.");
                return;
            }

            if (MessageBox.Show(string.Format(
                "Bạn có chắc thanh toán hóa đơn cho bàn {0}?\nTổng tiền: {1} - ({1} / 100) x {2} = {3}",
                table.Name, totalPrice, discount, finalTotalPrice), "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(idBill.Value, discount, (float)finalTotalPrice);
                ShowBill(table.ID);
                LoadTable();
            }

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag is not Table table1)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbSwitchTable.SelectedItem is not Table table2)
            {
                MessageBox.Show("Vui lòng chọn bàn đích để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}",
                table1.Name,
                table2.Name),
                "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(table1.ID, table2.ID);
                LoadTable();
            }
        }


    }
}
