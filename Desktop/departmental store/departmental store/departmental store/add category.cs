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
    public partial class add_category : Form
    {
        public add_category()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
            categories newCategories = new categories();
            newCategories.Name = category_name.Text;
            categories_data.CategoriesArrayList.Add(newCategories);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            category newCategory = new category();
            newCategory.Show();
            this.Hide();
        }
    }
}
