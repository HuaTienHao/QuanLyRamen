using QLCuaHangRamen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangRamen.DAO
{
    public class FoodListDAO
    {
        private static FoodListDAO instance;

        public static FoodListDAO Instance
        {
            get { if (instance == null) instance = new FoodListDAO(); return FoodListDAO.instance; }
            private set { FoodListDAO.instance = value; }
        }

        private FoodListDAO() { }

        public List<FoodList> GetFoodListForAdmin()
        {
            List<FoodList> listMenu = new List<FoodList>();

            string query = "SELECT Category.CATEGORY_NAME, Food.FOOD_NAME, Food.PRICE FROM TBL_CATEGORY as Category, TBL_FOOD as Food WHERE Category.CATEGORY_ID = Food.CATEGORY_ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodList menu = new FoodList(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
