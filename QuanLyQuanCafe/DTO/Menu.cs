using System;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Menu  
    {
        
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName ?? throw new ArgumentNullException(nameof(foodName), "FoodName cannot be null");
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["Name"]?.ToString() ?? string.Empty; // Nếu Name là null, gán chuỗi rỗng
            this.Count = row["count"] != DBNull.Value ? Convert.ToInt32(row["count"]) : 0;  // Chuyển đổi sang int, đảm bảo dữ liệu không null
            this.Price = row["price"] != DBNull.Value ? Convert.ToSingle(row["price"]) : 0.0f;  // Chuyển đổi sang float
            this.TotalPrice = row["totalPrice"] != DBNull.Value ? Convert.ToSingle(row["totalPrice"]) : 0.0f;   // Chuyển đổi sang float
        }
        
        public string FoodName { get; set; }

       
        public int Count { get; set; }

        public float Price { get; set; }

      
        public float TotalPrice { get; set; }
    }
}
