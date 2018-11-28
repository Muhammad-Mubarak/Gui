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
            DatabaseConnection.getInstance().ConnectionString =
                @"data source = (localhost)\MSSQLSERVER01 ; initial catalog = Departmental_store ;integrated security = true ; User id = sa; password = uetlhr123";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name = productname.Text;
            int invoice_id = Int32.Parse(invoiceid.Text);
            int product_quantity = Int32.Parse(quantity.Text);
            int purchase_price = Int32.Parse(purchaseprice.Text);
            int sell_price  = Int32.Parse(sellprice.Text);
            String productFormat = String.Format("INSERT INTO Product(Product_name,Product_id,Quantity,purchase_price,sell_price) values(name , invoice_id,product_quantity,purchase_price,sell_price)", name,invoice_id,product_quantity,purchase_price,sell_price );
            int rows = DatabaseConnection.getInstance().exectuteQuery(productFormat);
            MessageBox.Show(String.Format("{0} rows affected", rows));



        }
    }
}
