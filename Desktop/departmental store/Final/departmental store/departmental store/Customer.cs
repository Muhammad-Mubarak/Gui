using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace departmental_store
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void DMS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard newDashboard = new Dashboard();
            newDashboard.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Purchase_form newPurchaseForm = new Purchase_form();
            this.Hide();
            newPurchaseForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sale newSale = new sale();
            newSale.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stock newStock = new stock();
            newStock.Show();
            this.Hide();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            configuration nwConfiguration = new configuration();
            nwConfiguration.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            account newAccount = new account();
            this.Hide();
            newAccount.Show();

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            report newReport = new report();
            newReport.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Form1 loginForm1 = new Form1();
            loginForm1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_customer newAddCustomer = new add_customer();
            newAddCustomer.Show();
            this.Hide();
        }
    }
}
