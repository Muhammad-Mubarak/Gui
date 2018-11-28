using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace departmental_store
{
    public partial class Signup_form : Form
    {
        public Signup_form()
        {
            InitializeComponent();
            DatabaseConnection.getInstance().ConnectionString = @"data source = (localhost)\MSSQLSERVER01 ; initial catalog = Departmental_store ;integrated security = true ; User id = sa; password = uetlhr123";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                string name = this.name.Text;
                string passcode = password.Text;
                string position = this.position.Text;

                var con = DatabaseConnection.getInstance().getConnection();
                con.Open();

                string cmd =
                    string.Format("insert into Users(Username,Password,Position)values(name , passcode, position)",
                        name, passcode, position);
                int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
                MessageBox.Show("Connection succeeded");


               
                

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            

            //
         /*Form1 redirectForm1 = new Form1();
            redirectForm1.Show();
            this.Hide();

            // here this block refers to the insertion of data into sql tables;
            User user = new User();
            user.Username = name.Text;
            user.Password = password.Text;
            user.Position = position.Text;
            bool result =saved_result(user);
            MessageBox.Show("Saved");
            */



        }

       /* private bool saved_result(User user_object)
        {
            bool result = false;
            using (Departmental_storeEntities1 _entities1 = new Departmental_storeEntities1())
            {
                _entities1.Users.Add(user_object);

                try
                {
                    _entities1.SaveChanges();
                }

                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
                result = true;
            }

            return result;
        } */


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 redirectForm1 = new Form1();
            redirectForm1.Show();
            this.Hide();
        }
    }
}
