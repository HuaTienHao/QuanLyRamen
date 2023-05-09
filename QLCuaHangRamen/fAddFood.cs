using QLCuaHangRamen.DAO;
using QLCuaHangRamen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangRamen
{
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();

            LoadCategory();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbAddCategory.DataSource = listCategory;
            cbAddCategory.DisplayMember= "Name";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string foodname = txbAddName.Text;
            int idCategory = (cbAddCategory.SelectedItem as Category).ID;
            float price = (float)nmAddPrice.Value;

            if (foodname != "")
            {
                if (FoodDAO.Instance.AddFood(foodname, idCategory, price))
                    MessageBox.Show("Add food succeeded!");
                
                else MessageBox.Show("Add food failed...");
            }
            else MessageBox.Show("Food name mustn't be empty");

        }
    }
}
