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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_category newCategory = new add_category();
            this.Hide();
            newCategory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subcategory newSubcategory = new Subcategory();
            this.Hide();
            newSubcategory.Show();
        }
    }
}
