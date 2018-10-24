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
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.Show();
            this.Hide();
        }
    }
}
