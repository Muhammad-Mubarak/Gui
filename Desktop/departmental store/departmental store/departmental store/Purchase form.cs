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
    public partial class Purchase_form : Form
    {
        public Purchase_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            product_list  new_product = new product_list();
            new_product.Show();
            this.Hide();

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Dashboard afterDashboard = new Dashboard();
            this.Hide();
            afterDashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
