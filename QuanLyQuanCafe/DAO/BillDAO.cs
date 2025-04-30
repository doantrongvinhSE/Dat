using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO? instance;

        public static BillDAO Instance => instance ??= new BillDAO();

        private BillDAO() { }

        public int? GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID; 
            }

            return null;
        }


        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int idTable)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_CreateBill @idTable", new object[] { idTable });
        }


        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn, @checkOut", new object[] {checkIn, checkOut });
        }

        public DataTable GetBillListByTable(int tableId, DateTime checkIn, DateTime checkOut)
        {
            string query = "exec USP_GetListBillByTable @idTable , @checkIn, @checkOut";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tableId, checkIn, checkOut });
        }

        public DataTable GetBillListByFood(string nameFood, DateTime checkIn, DateTime checkOut)
        {
            string query = "exec USP_GetListBillByFood @foodName, @checkIn, @checkOut";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nameFood, checkIn, checkOut });
        }




        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }

}
