using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using PrintDialog = System.Windows.Controls.PrintDialog;


namespace departmental_store
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard newDashboard = new Dashboard();
            this.Hide();
            newDashboard.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDialog newDialog = new PrintDialog();
            newDialog.PageRangeSelection = PageRangeSelection.AllPages;
            newDialog.UserPageRangeEnabled = true;

            bool? result = newDialog.ShowDialog();
            if (result == true)
            {
                // logic here
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dashboard newDashboard = new Dashboard();
            newDashboard.Show();
            this.Hide();
        }
    }
}
