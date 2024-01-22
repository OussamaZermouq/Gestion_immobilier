using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data;
using System.Data.SqlClient;
using Gestion_immobilier.Database;
using Telerik.WinControls.UI;
using Gestion_immobilier.Admin;
using Telerik.WinControls.Themes;

namespace Gestion_immobilier
{
    public partial class Ajouter_reclamation : Telerik.WinControls.UI.RadForm
    {
        public SqlDataReader dr;
        public SqlConnection connection;
        public static int id_user;
        public static int reclamation_id;

        public Ajouter_reclamation()
        {
            InitializeComponent();
        }


        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }


        private void Ajouter_reclamation_Load(object sender, EventArgs e)
        {
            connection = Connection.Connect_to_db();
        }
        public string[] selectedFilePath;
        public  string[] ImportPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a Photo";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileNames;

                return selectedFilePath;
            }
            else
            {
                return null; // User canceled the operation
            }
        }


        private void radButton1_Click(object sender, EventArgs e)
        {

            foreach (string s in ImportPhoto())
            {
                radLabel4.Visible = true;

                radLabel4.Text += s + '\n';

            }


        }
        public void ajouter()

        {
            int id_user = Login.user_id;

            string query = "insert into reclamation values ('" + radRichTextEditor1.Text + "', GETDATE(),'non_valider'," + id_user + ")";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                object output = cmd.ExecuteNonQuery();
                if (System.Convert.ToInt32(output) > 0)
                {
                    string query2 = $"select * from reclamation  where  locataire_id=" + id_user + "and description ='" + radRichTextEditor1.Text + "'  ";
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    dr = cmd2.ExecuteReader();
                   

                    while (dr.Read())
                    {
                        RadMessageBox.Show(" votre code de reclamation est: " + dr[0].ToString());
                        reclamation_id = System.Convert.ToInt32(dr[0].ToString());

                    }
                    dr.Close();
                    foreach (string s in selectedFilePath)
                    {
                      
                         query = $"insert into reclamation_photos  values ('{s.Replace("'", "_")}',{reclamation_id})";
                         cmd = new SqlCommand(query, connection); 
                         cmd.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }

        }
        public void ajouter_photo()

        {
            /*int reclamation_id2 = reclamation_id;
            


            string query3 = "insert into reclamation_photos  values ('" + radLabel4.Text + "', " + reclamation_id2 + ")";
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            cmd3.ExecuteNonQuery();*/

        }





        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            ajouter();
            //ajouter_photo();
        }

        private void radButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Ajouter_reclamation_Load_1(object sender, EventArgs e)
        {

            theme_choose.Items.Add("Aqua");
            theme_choose.Items.Add("Default");
            theme_choose.Items.Add("Desert");

        }

        public void set_theme(string theme)
        {

            if (theme == "Aqua")
            {

                this.ThemeName = aquaTheme1.ThemeName;

            }
            else if (theme == "Default")
            {

                this.ThemeName = office2019LightTheme1.ThemeName;

            }
            else if (AdminMDI.theme == "Desert")
            {

                this.ThemeName = desertTheme1.ThemeName;

            }
        }

        private void theme_choose_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            set_theme(theme_choose.SelectedItem.ToString());

        }
    }
}


