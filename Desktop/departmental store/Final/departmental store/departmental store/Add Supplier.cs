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
    public partial class Add_Supplier : Form
    {
        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier newSupplier = new Supplier();
            newSupplier.Show();
            this.Hide();
        }
    }
}
