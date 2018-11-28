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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseConnection.getInstance().ConnectionString =
                @"data source = (localhost)\MSSQLSERVER01 ; initial catalog = Departmental_store ;integrated security = true ; User id = sa; password = uetlhr123";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string fetch_command = "Select * from User";
            var reader = DatabaseConnection.getInstance().getData(fetch_command);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User entityUser = new User();
                entityUser.Username = reader.GetString(1);
                entityUser.Password = reader.GetString(2);
                entityUser.Position = reader.GetString(3);
                users.Add(entityUser);

            }

            foreach (var user_entity in users)
            {
                if (user_entity.Username == name.Text && user_entity.Password == password.Text && user_entity.Position == Position.Text)
                {
                    Dashboard loginDashboard = new Dashboard();
                    loginDashboard.Show();
                    this.Hide();
                }
            }












        }


        // actually we are accessing database table's data into list here........ //



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_form newSignupForm = new Signup_form();
            newSignupForm.Show();
            this.Hide();
        }
    }
}
