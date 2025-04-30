using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;


namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO? instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO()
        {

        }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM Food WHERE name LIKE N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int categoryID, float price)
        {
            string query = "INSERT INTO dbo.Food (name, idCategory, price) VALUES (@name, @idCategory, @price)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, categoryID, price });
            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int categoryID, float price)
        {
            string query = "UPDATE dbo.Food SET name = @name, idCategory = @idCategory, price = @price WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, categoryID, price, idFood });
            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("DELETE FROM dbo.Food WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
