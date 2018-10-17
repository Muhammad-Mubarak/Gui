using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace departmental_store
{
    public partial class New_Product : Form
    {
        public New_Product()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            product_list newProductList = new product_list();
            this.Hide();
            newProductList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            category newCategory = new category();
            this.Hide();
            newCategory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stock newsStock = new stock();
            this.Hide();
            newsStock.Show();
        }
    }
}
