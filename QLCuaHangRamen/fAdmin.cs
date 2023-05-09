using QLCuaHangRamen.DAO;
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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadListFood();
            LoadListBill(); 
        }

        void LoadListFood()
        {
            dtgvFood.DataSource = FoodListDAO.Instance.GetFoodListForAdmin();
        }
        void LoadListBill()
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillList();
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
        }
        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            fRemoveFood f = new fRemoveFood();
            f.ShowDialog();
        }

        private void btnRefreshFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void btnUpdateFood_Click_1(object sender, EventArgs e)
        {
            fUpdateFood f = new fUpdateFood();
            f.ShowDialog();
        }
    }
}
