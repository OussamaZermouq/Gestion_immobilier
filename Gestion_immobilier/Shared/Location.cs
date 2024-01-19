using Gestion_immobilier.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Gestion_immobilier.Shared
{
    public partial class Location : Telerik.WinControls.UI.RadForm
    {

        Connection connection = null;
        SqlDataReader dr = null;
        DataTable Dt;
        public Location()
        {
            InitializeComponent();
        }

        public void remplir_comboboxes()
        {
            dr = connection.renvoyer_Data_Reader("select username from users where role ='Agent Immobilier'");
            while (dr.Read())
            {
                agent_drop_down.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            dr = connection.renvoyer_Data_Reader("select nom_contract from contracts");
            while (dr.Read())
            {
                contrat_drop_down.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            dr = connection.renvoyer_Data_Reader("select username from users where role ='Locataire'");
            while (dr.Read())
            {
                locataire_drop_down.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            //bach ijib gha li bien li machi mekriwin
            dr = connection.renvoyer_Data_Reader("select nom from Bien b left join location l on b.id_bien = l.bien_id where DATEDIFF(mm,l.location_date_fin,getdate())>0");
            while (dr.Read())
            {
                Bien_drop_down.Items.Add(dr.GetValue(0).ToString());
            }

            //to prevent crashes when reloading the form
            dr.Close();

        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            if (nom_location.Text == "" || date_location_debut.Text == "" || date_location_fin.Text == "" || contrat_drop_down.SelectedItem.ToString() == "" || Bien_drop_down.Text == "" || locataire_drop_down.Text=="")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                string sql = $"Insert into location values ('{nom_location.Text}', '{date_location_debut.Text}', '{date_location_fin.Text}',(select user_id from users where username='{locataire_drop_down.Text}'),(select user_id from users where username='{agent_drop_down.Text}'),(select id_bien from Bien where nom='{Bien_drop_down.Text}'), (select id_contract from contracts where nom_contract='{contrat_drop_down.Text}'))";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Location ajouter!");
                }
                else
                {
                    RadMessageBox.Show("Erreur, Veuillez réessayer");

                }
                remplir_dgv();
            }
        }
        public void remplir_dgv()
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté("Select * from location");
            radGridView1.DataSource = Dt;

        }

        private void Location_Load(object sender, EventArgs e)
        {

            connection = new Connection();
            remplir_comboboxes();
            remplir_dgv();

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (nom_location.Text == "" || date_location_debut.Text == "" || date_location_fin.Text == "" || contrat_drop_down.SelectedItem.ToString() == "" || Bien_drop_down.Text == "" || locataire_drop_down.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                string sql = $"Update location set  location_date_debut='{date_location_debut.Text}', location_date_fin='{date_location_fin.Text}',locataire_id=(select user_id from users where username='{locataire_drop_down.Text}'),agent_immo=(select user_id from users where username='{agent_drop_down.Text}'),bien_id=(select id_bien from Bien where nom='{Bien_drop_down.Text}'), id_contract=(select id_contract from contracts where nom_contract='{contrat_drop_down.Text}') where location_nom='{nom_location.Text}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Location modifier!");
                }
                else
                {
                    RadMessageBox.Show("Erreur, Veuillez réessayer");

                }
                remplir_dgv();
            }

        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            string sql = $"Delete location where location_nom='{nom_location.Text}'";
            if (connection.executer(sql) > 0)
            {
                RadMessageBox.Show("Location supprimer!");
            }
            remplir_dgv();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté($"select * from location where location_nom='{nom_location.Text}'");
            radGridView1.DataSource = Dt;
        }
    }
}
