using Gestion_immobilier.Admin;
using Gestion_immobilier.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;

namespace Gestion_immobilier.Shared
{
    public partial class Client : Telerik.WinControls.UI.RadForm
    {
        public DataTable Dt;
        Connection connection = null;
        public Client()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (nom_input.Text == "" || prenom_input.Text == "" || date_naissance_client.Text == "" || type_drop_down.SelectedItem.ToString() == "" || num_tel_client.Text =="")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
               string sql = $"Insert into Client values('{nom_input.Text}', '{prenom_input.Text}', '{date_naissance_client.Text}','{num_tel_client.Text}', '{type_drop_down.Text}')";
               if (connection.executer(sql) > 0)
               {
                   RadMessageBox.Show("Client ajouter!");
               }
               remplir_dgv();
               
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

            theme_choose.Items.Add("Aqua");
            theme_choose.Items.Add("Default");
            theme_choose.Items.Add("Desert");
            connection = new Connection();
            remplir_combobox_types();
            remplir_dgv();
        }


        public void remplir_dgv()
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté("Select * from client");
            radGridView1.DataSource = Dt;

        }

        public void remplir_combobox_types()
        {
            type_drop_down.Items.Add("Acheteur");
            type_drop_down.Items.Add("Locataire");

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (nom_input.Text == "" || prenom_input.Text == "" || date_naissance_client.Text == "" || type_drop_down.SelectedItem.ToString() == "" || num_tel_client.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                string sql = $"Update Client set prenom_client = '{prenom_input.Text}', date_naissance = '{date_naissance_client.Text}', num_telephone_client = '{num_tel_client.Text}', client_type='{type_drop_down.Text}' where nom_client = '{nom_input.Text}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Client modifier!");
                }
                remplir_dgv();

            }

        }
        private void supprimer_Click(object sender, EventArgs e)
        {

            string sql = $"Delete client where nom_client='{nom_input.Text}'";
            if (connection.executer(sql) > 0)
            {
                RadMessageBox.Show("Client supprimer!");
            }
            remplir_dgv();
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
