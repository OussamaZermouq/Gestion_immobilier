using Gestion_immobilier.Admin;
using Gestion_immobilier.Database;
using MediaFoundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using Telerik.Windows.Diagrams.Core;

namespace Gestion_immobilier
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radPictureBox1_ImageLoaded(object sender, EventArgs e)
        {

        }
        public static string user_role;
        public SqlConnection connection;
        private void Login_Load(object sender, EventArgs e)
        {
            connection = Connection.Connect_to_db();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

            string query = $"select count(*) as user_count from users where username='{username_input.Text}' and password='{password_input.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteScalar();
                if (Convert.ToInt32(output) > 0)
                {
                    query = $"select role from users where username='{username_input.Text}' and password='{password_input.Text}'";
                    var role = new SqlCommand(query, connection).ExecuteScalar();
                    if (role.ToString() == "admin")
                    {
                        this.Hide();
                        AdminMDI adminMDI= new AdminMDI();
                        adminMDI.Show();
                    }
                    RadMessageBox.Show("Login successful");
                }
                else
                {

                    RadMessageBox.Show("Login failed");

                }

            }
            catch(Exception ex)
            {

                RadMessageBox.Show(ex.Message);
            
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
