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
    public partial class Vente : Telerik.WinControls.UI.RadForm
    {
        Connection connection = null;
        SqlDataReader dr = null;
        DataTable Dt;
        public Vente()
        {
            InitializeComponent();
        }

        private void Vente_Load(object sender, EventArgs e)
        {
            connection = new Connection();
            remplir_comboboxes();

        }

        public void remplir_comboboxes()
        {
            dr = connection.renvoyer_Data_Reader("select username from users where role ='Agent Immobilier'");
            while (dr.Read())
            {
                agent_drop_down.Items.Add(dr.GetValue(0).ToString());
            }

            dr = connection.renvoyer_Data_Reader("select nom_contract from contracts");
            while (dr.Read())
            {
                contrat_drop_down.Items.Add(dr.GetValue(0).ToString());
            }


            dr = connection.renvoyer_Data_Reader("select nom from Bien");
            while (dr.Read())
            {
                Bien_drop_down.Items.Add(dr.GetValue(0).ToString());
            }

            //to prevent crashes when reloading the form
            dr.Close();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (nom_vente.Text == "" || date_vente.Text == "" || agent_drop_down.Text == "" || contrat_drop_down.SelectedItem.ToString() == "" || Bien_drop_down.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                string sql = $"Insert into vente values ('{nom_vente}', '{date_vente.Text}', '{agent_drop_down.Text}','{Bien_drop_down.Text}', '{contrat_drop_down.Text}')";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Vente ajouter!");
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
            Dt = connection.renvoyer_liste_deconnecté("Select * from vente");
            radGridView1.DataSource = Dt;

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (nom_vente.Text == "" || date_vente.Text == "" || agent_drop_down.Text == "" || contrat_drop_down.SelectedItem.ToString() == "" || Bien_drop_down.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                string sql = $"Update vente set date_vente='{date_vente.Text}', agent_locataire_id={agent_drop_down.Text}, bien_id='{Bien_drop_down.Text}', id_contract='{contrat_drop_down.Text}' where nom_vente='{nom_vente.Text}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Vente modifier!");
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
            string sql = $"Delete vente where nom_vente='{nom_vente.Text}'";
            if (connection.executer(sql) > 0)
            {
                RadMessageBox.Show("Vente supprimer!");
            }
            remplir_dgv();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté($"select * from vente where nom_vente='{nom_vente.Text}'");
            radGridView1.DataSource = Dt;
        }
    }
}
