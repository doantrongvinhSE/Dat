using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;


namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO? instance; // Không khởi tạo ngay

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            // Kiểm tra nếu username là "k9" và pass là "1"
            if (userName == "k9" && passWord == "1")
            {
                return true; // Nếu đúng thì cho phép đăng nhập vào admin
            }

            // Còn lại, kiểm tra trong cơ sở dữ liệu
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0; // Chỉ cho phép đăng nhập với các tài khoản trong DB
        }


        public bool UpdateAccount(string name, string displayName, string newPassword, int type)
        {
            string query = "UPDATE dbo.Account SET DisplayName = @displayName, Type = @type, Password = @newPassword WHERE UserName = @userName";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { displayName, type, newPassword ,name });

            return result > 0;
        }







        public DataTable GetListAccount()
        {
            string query = "SELECT UserName, DisplayName, Type, Password FROM Account";
            return DataProvider.Instance.ExecuteQuery(query); // <== dùng biến query ở đây
        }


        public Account GetAccountByUserName(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null; 
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account (Username, DisplayName, Type) VALUES ( N'{0}', N'{1}', {2})", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }



        public bool DeleteAccount(string name)
        {
             
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE Account SET Password = N'0' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;  
        }


    }
}