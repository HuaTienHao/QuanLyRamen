using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangRamen.DTO
{
    public class FoodList
    {
        public FoodList(string category_name, string foodName, float price)
        {
            this.Category_Name = category_name;
            this.Food_Name= foodName;
            this.Price= price;
        }

        public FoodList(DataRow row)
        {
            this.Category_Name = row["CATEGORY_NAME"].ToString();
            this.Food_Name = row["FOOD_NAME"].ToString();
            this.price = (float)Convert.ToDouble(row["PRICE"].ToString());
        }

        private string category_name;
        private string foodName;
        private float price;

        public string Category_Name { get => category_name; set => category_name = value; }
        public string Food_Name { get => foodName; set => foodName = value; }
        public float Price { get => price; set => price = value; }
    }
}
