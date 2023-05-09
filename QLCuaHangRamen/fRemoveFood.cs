using QLCuaHangRamen.DAO;
using QLCuaHangRamen.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangRamen
{
    public partial class fRemoveFood : Form
    {
        public fRemoveFood()
        {
            InitializeComponent();

            LoadCategory();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbRemoveCategory.DataSource = listCategory;
            cbRemoveCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbRemoveName.DataSource = listFood;
            cbRemoveName.DisplayMember = "Name";
        }

        private void cbRemoveCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            int id = (cbRemoveName.SelectedItem as Food).ID;

            if (FoodDAO.Instance.RemoveFood(id))
                MessageBox.Show("Remove food succeeded!");

            else MessageBox.Show("Remove food failed...");
        }
    }
}
