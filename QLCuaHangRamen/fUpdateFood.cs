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
    public partial class fUpdateFood : Form
    {
        public fUpdateFood()
        {
            InitializeComponent();

            LoadCategory();
            LoadCategoryComboBox(cbUpdateCategory);
            ShowInfo();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbSelectCategory.DataSource = listCategory;
            cbSelectCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbSelectName.DataSource = listFood;
            cbSelectName.DisplayMember = "Name";
        }

        void ShowInfo()
        {
            int id = (cbSelectName.SelectedItem as Food).ID;
            string name = (cbSelectName.SelectedItem as Food).Name;
            float price = (cbSelectName.SelectedItem as Food).Price;

            txbFoodID.Text = id.ToString();
            txbUpdateName.Text = name.ToString();
            nmUpdatePrice.Value = (decimal)price;
        }

        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string foodname = txbUpdateName.Text;
            int idCategory = (cbUpdateCategory.SelectedItem as Category).ID;
            float price = (float)nmUpdatePrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, foodname, idCategory, price))
                MessageBox.Show("Update food succeeded!"); 
            
            else MessageBox.Show("Update food failed...");
        }

        void LoadCategoryComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void cbSelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {

            int id = (cbSelectName.SelectedItem as Food).CategoryID;
            Category category = CategoryDAO.Instance.GetCategoryByID(id);
            cbUpdateCategory.SelectedItem = category;

            int index = -1;
            int i = 0;
            foreach (Category item in cbUpdateCategory.Items)
            {
                if (item.ID == category.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }

            cbUpdateCategory.SelectedIndex = index;
        }
    }
}
