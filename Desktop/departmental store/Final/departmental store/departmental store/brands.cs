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
    public partial class brands : Form
    {
        public brands()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchase_form form = new Purchase_form();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Purchase_form form = new Purchase_form();
            form.Show();
            this.Hide();
        }
    }
}
