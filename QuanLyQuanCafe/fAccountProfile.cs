using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;
        private object numericUpDown2;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            Account updatedAccount = AccountDAO.Instance.GetAccountByUserName(acc.UserName);

            if (updatedAccount != null)
            {
                txbUserName.Text = updatedAccount.UserName;
                txbDisplayName.Text = updatedAccount.DisplayName;
            }

            //txbUserName.Text = LoginAccount.UserName;
            //txbDisplayName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassWord.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txbUserName.Text;
            NumericUpDown nud = (NumericUpDown)numericUpDown2;
            int type = (int)nud.Value;


            // Kiểm tra mật khẩu mới và mật khẩu nhập lại
            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
            }
            else
            {
                // Gọi DAO để cập nhật tài khoản (không có mật khẩu trong UpdateAccount)
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, newpass ,type))
                {
                    MessageBox.Show("Cập nhật thành công");

                    Account updatedAccount = AccountDAO.Instance.GetAccountByUserName(userName);

                    if (updatedAccount != null)
                    {
                        // Sự kiện cập nhật tài khoản thành công
                        updateAccount?.Invoke(this, new AccountEvent(updatedAccount));
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tài khoản không thành công, tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        void LoadAccountInfo(string userName)
        {
            Account updatedAccount = AccountDAO.Instance.GetAccountByUserName(userName);

            if (updatedAccount != null)
            {
                txbUserName.Text = updatedAccount.UserName;
                txbDisplayName.Text = updatedAccount.DisplayName;
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc có lỗi khi lấy thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string passwordNew = HashPasswordSHA256(txbNewPass.Text);            

            int type = 0;

            bool success = AccountDAO.Instance.UpdateAccount(username, displayName, passwordNew, type);

            if (success)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");

                LoadAccountInfo(username);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        public static string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }




        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbReEnterPass_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
