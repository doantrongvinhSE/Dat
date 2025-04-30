using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();

            accountList = new BindingSource();


            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;


            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            LoadCategoryIntoCombobox(cbFoodCategory);
            LoadListFood();
            AddFoodBinding();

            LoadAccount();
            AddAccountBinding();

        }

        #region methods

        void LoadData()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            AddFoodBinding();
            LoadAccount();

        }

        void AddAccountBinding()
        {
            // Clear binding cũ nếu có
            txbUserName.DataBindings.Clear();
            txbDisplayName.DataBindings.Clear();
            numericUpDown2.DataBindings.Clear();

            // Binding textbox và numeric
            txbUserName.DataBindings.Add("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txbDisplayName.DataBindings.Add("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);
            numericUpDown2.DataBindings.Add("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never);

            // Không để auto cập nhật khi không cần thiết
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tpFood_Click(object sender, EventArgs e)
        {

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                InsertFood?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món ");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txbFoodID.Text))
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa.");
                return;
            }

            int id;
            if (!int.TryParse(txbFoodID.Text, out id))
            {
                MessageBox.Show("ID không hợp lệ.");
                return;
            }

            // Hỏi lại người dùng trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa món này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            // Gọi DAO để xóa
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                DeleteFood?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Có lỗi khi bạn xóa món");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút Xóa
        }
        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý khi tab thay đổi (nếu cần)
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text); // Sửa lại dòng này

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price)) // Đưa id vào đúng vị trí
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                UpdateFood?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Có lỗi khi bạn sửa món ");
            }
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click trên DataGridView
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }


        void LoadListBillByTable(int tableId ,DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByTable(tableId, checkIn, checkOut);
        }

        void LoadListBillByFood(string foodName, DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByFood(foodName, checkIn, checkOut);
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, "vvv2002tb" ,type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }





        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Bạn không được xóa chính bản thân bạn");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu");
            }
        }

        void AddFoodBinding()
        {
            // Clear binding cũ nếu có
            txbFoodName.DataBindings.Clear();
            txbFoodID.DataBindings.Clear();
            nmFoodPrice.DataBindings.Clear();
            cbFoodCategory.DataBindings.Clear();

            // Binding textbox và numeric
            txbFoodName.DataBindings.Add("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txbFoodID.DataBindings.Add("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never);
            nmFoodPrice.DataBindings.Add("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never);

            // ComboBox: cần set DisplayMember, ValueMember
            cbFoodCategory.DisplayMember = "Name";
            cbFoodCategory.ValueMember = "ID";

            // Binding SelectedValue với CategoryID
            cbFoodCategory.DataBindings.Add("SelectedValue", dtgvFood.DataSource, "CategoryID", true, DataSourceUpdateMode.Never);
        }


        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        #endregion



        #region events
        private void btnViewbill_Click(object sender, EventArgs e)
        {
            if (cbbTypeStatistics.SelectedIndex == 1)
            {
                int tableId = int.Parse(cbbTable.Text.Split(' ').Last().Trim());

                LoadListBillByTable(tableId, dtpkFromDate.Value, dtpkToDate.Value);
            }
            else if (cbbTypeStatistics.SelectedIndex == 2)
            {
                string foodName = cbbTable.Text.Trim();
                LoadListBillByFood(foodName, dtpkFromDate.Value, dtpkToDate.Value);
            }
            else
            {
                LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            }



        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.Rows.Count > 0)
                {
                    DataGridViewRow row = dtgvFood.Rows[0]; // lấy dòng đầu tiên sau tìm kiếm
                    object value = row.Cells["CategoryID"].Value;

                    if (value != null)
                    {
                        int id = Convert.ToInt32(value);
                        Category category = CategoryDAO.Instance.GetCategoryByID(id);
                        cbFoodCategory.SelectedItem = category;

                        int index = -1;
                        int i = 0;
                        foreach (Category item in cbFoodCategory.Items)
                        {
                            if (item.ID == category.ID)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                        cbFoodCategory.SelectedIndex = index;
                    }
                }

            }
            catch
            {
                // Có thể ghi log lỗi ở đây nếu cần
            }
        }


        public event EventHandler InsertFood;
        public event EventHandler DeleteFood;
        public event EventHandler UpdateFood;


        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDown2.Value;

            AddAccount(userName, displayName, type);
        }





        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;


            DeleteAccount(userName);
        }
        private bool isResetPassword = false;

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            isResetPassword = (numericUpDown2.Value == 0);
        }


        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)numericUpDown2.Value;

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, "vvv2002tb", type))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại!");
            }
        }


        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");

                int type = (int)numericUpDown2.Value;

                if (type != loginAccount.Type) // Kiểm tra xem loại tài khoản có thay đổi không
                {
                    if (AccountDAO.Instance.UpdateAccount(userName, txbDisplayName.Text, "vvv2002tb" ,type))
                    {
                        MessageBox.Show("Cập nhật loại tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật loại tài khoản!");
                    }
                }

                LoadAccount();
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }





        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvAccount.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dtgvAccount.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvAccount.Rows[selectedRowIndex];

                txbUserName.Text = selectedRow.Cells["UserName"].Value.ToString();
                txbDisplayName.Text = selectedRow.Cells["DisplayName"].Value.ToString();
                numericUpDown2.Value = Convert.ToInt32(selectedRow.Cells["Type"].Value);
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string name = txbSearchFoodName.Text; // textbox bạn dùng để nhập tên món ăn cần tìm

            List<Food> listFood = SearchFoodByName(name); // gọi hàm tìm kiếm

            foodList.DataSource = listFood;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowAccount_Click_1(object sender, EventArgs e)
        {

        }

        private void cbbTypeStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeStatistics.SelectedIndex == 1)
            {
                List<Table> listTable = TableDAO.Instance.LoadTableList();

                List<string> tableName = listTable.Select(table => table.Name).ToList();

                cbbTable.DataSource = tableName;
            }

            if (cbbTypeStatistics.SelectedIndex == 2)
            {
                List<Food> listFood = FoodDAO.Instance.GetListFood();
                List<string> foodName = listFood.Select(food => food.Name).ToList();

                cbbTable.DataSource = foodName;

            }


        }
    }
}
