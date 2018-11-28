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
    public partial class Subcategory : Form
    {
        public Subcategory()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            category newCategory = new category();
            this.Hide();
            newCategory.Show();

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            subcategories newSubcategories = new subcategories();
            newSubcategories.Name = categorysub.Text;
            subcategory_data.SubList.Add(newSubcategories);
        }
    }
}
