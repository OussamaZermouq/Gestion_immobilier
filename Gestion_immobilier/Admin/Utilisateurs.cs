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
using Telerik.WinControls;
using Telerik.WinForms.Documents.Model.Themes;

namespace Gestion_immobilier.Admin
{
    public partial class Utilisateurs : Telerik.WinControls.UI.RadForm
    {
        Connection connection = null;
        public DataTable Dt;


        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "" || password_input.Text == "" || pasword_retype_password.Text == "" || role_drop_down.SelectedItem.ToString() == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                if (password_input.Text.Length < 8)
                {
                    RadMessageBox.Show("Veuillez choisir un mot de passe plus securise, plus de 8 characteres!");
                }
                else if (password_input.Text != pasword_retype_password.Text)
                {
                    RadMessageBox.Show("Les mot de passes doivent etre identiques");
                }
                else
                {
                    string sql = $"Insert into users values('{username_input.Text}', '{password_input.Text}', '{role_drop_down.SelectedItem.Text}')";
                    if (connection.executer(sql) > 0)
                    {
                        RadMessageBox.Show("Utilisateurs ajouter!");
                    }
                    remplir_dgv();
                }
            }
           
        }

        public void remplir_dgv()
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté("Select * from users");
            radGridView1.DataSource = Dt;
            
        }


        public void remplir_combobox_roles()
        {
            role_drop_down.Items.Add("Admin");
            role_drop_down.Items.Add("Proprietere");
            role_drop_down.Items.Add("Agent Immobilier");
            role_drop_down.Items.Add("Locataire (Client)");

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
        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            theme_choose.Items.Add("Aqua");
            theme_choose.Items.Add("Default");
            theme_choose.Items.Add("Desert");

            connection = new Connection();
            remplir_combobox_roles();
            remplir_dgv();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "" || password_input.Text == "" || pasword_retype_password.Text == "" || role_drop_down.SelectedItem.ToString() == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                if (password_input.Text.Length < 8)
                {
                    RadMessageBox.Show("Veuillez choisir un mot de passe plus securise, plus de 8 characteres!");
                }
                else if (password_input.Text != pasword_retype_password.Text)
                {
                    RadMessageBox.Show("Les mot de passes doivent etre identiques");
                }
                else
                {
                    string sql = $"Update users set password='{password_input.Text}', role ='{role_drop_down.Text}' where username ='{username_input.Text}'";
                    if (connection.executer(sql) > 0)
                    {
                        RadMessageBox.Show("Utilisateurs modifier!");
                    }
                    remplir_dgv();
                }
            }

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir le champs de username!");
            }
            else
            {
                string sql = $"delete users where username ='{username_input.Text}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Utilisateur supprimer!");
                }
                remplir_dgv();

            }
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté($"select * from users where username= '{username_input.Text}'");
            radGridView1.DataSource = Dt;
        }

        private void theme_choose_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            set_theme(theme_choose.SelectedItem.ToString());
        }
    }
}
