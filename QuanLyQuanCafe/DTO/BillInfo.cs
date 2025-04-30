using System;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo() { }

        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

        public int ID { get; set; }

        public int BillID { get; set; }

        public int FoodID { get; set; }

        public int Count { get; set; }
    }
}
