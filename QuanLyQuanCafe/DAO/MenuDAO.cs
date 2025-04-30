using QuanLyQuanCafe.DAO;
using System.Data;
using QuanLyQuanCafe.DTO;

public class MenuDAO
{
    // Không cần phải khai báo nullable cho instance
    private static MenuDAO instance = new MenuDAO(); // Khởi tạo ngay lập tức

    public static MenuDAO Instance
    {
        get { return instance; }
    }

    private MenuDAO() { }

    public List<Menu> GetListMenuByTableID(int id)
    {
        List<Menu> listMenu = new List<Menu>();

        string query = "SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice " +
                       "FROM dbo.BillInfo AS bi " +
                       "INNER JOIN dbo.Bill AS b ON bi.idBill = b.id " +
                       "INNER JOIN dbo.Food AS f ON bi.idFood = f.id " +
                       "WHERE b.status = 0 AND b.idTable = @id";

        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

        foreach (DataRow item in data.Rows)
        {
            Menu menu = new Menu(item);
            listMenu.Add(menu);
        }

        return listMenu;
    }




}
