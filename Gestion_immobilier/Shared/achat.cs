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
using Telerik.WinControls.UI;

namespace Gestion_immobilier
{
    public partial class achat : Telerik.WinControls.UI.RadForm
    {
        public SqlConnection connection;
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public achat()
        {
            InitializeComponent();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }


        private void achat_Load(object sender, EventArgs e)
        {
            connection = Connection.Connect_to_db();
            remplire_grid();
            remplirecombo1(); remplirecombo2(); remplirecombo3();

        }
        public void remplire_grid()
        {

            int id_locataire = Login.user_id;
            string query = " select  id_achat as numero,nom_achat,date_achate,agent_locataire_id,bien_id,id_contract from achat ";
            SqlCommand cmd = new SqlCommand(query, connection);
            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            radGridView1.DataSource = dt;
            dr.Close();


        }
        public void remplirecombo1()
        {
            agent_drop_down.Items.Clear();


            string query = "select  username  from users  ";
            SqlCommand cmd = new SqlCommand(query, connection);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agent_drop_down.Items.Add(dr[0].ToString());

            }
            dr.Close();
        }
        public void remplirecombo2()
        {
            Bien_drop_down.Items.Clear();


            string query = "select  nom  from Bien  ";
            SqlCommand cmd = new SqlCommand(query, connection);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Bien_drop_down.Items.Add(dr[0].ToString());

            }
            dr.Close();
        }
        public void remplirecombo3()
        {
            contrat_drop_down.Items.Clear();


            string query = "select  nom_contract from contracts ";
            SqlCommand cmd = new SqlCommand(query, connection);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                contrat_drop_down.Items.Add(dr[0].ToString());

            }
            dr.Close();
        }
        public void ajouter2()

        {



            string query = $"Insert into achat values ('{nom_vente.Text}', '{date_vente.Text}', (select user_id from users where username='{agent_drop_down.Text}' ),(select id_bien from Bien where nom='{Bien_drop_down.Text}'   ), (select id_contract from contracts where nom_contract='{contrat_drop_down.Text}'  ))";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                object output = cmd.ExecuteNonQuery();
                if (System.Convert.ToInt32(output) > 0)
                {
                    remplire_grid();
                    RadMessageBox.Show(" Votre achat est ajouter ");
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }

        }
        private void Rechercher()
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(nom_vente.Text))
                {
                    string query = "SELECT * FROM achat WHERE nom_achat LIKE @contractid";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {

                        adapter.SelectCommand.Parameters.AddWithValue("@contractid", "" + nom_vente.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        radGridView1.DataSource = dt;
                        radGridView1.ClearSelection();
                    }
                }
                else
                {

                    remplire_grid();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show("Erreur lors de la recherche : " + ex.Message);
            }
        }
        public void supprimer2()
        {
            string query = "DELETE  from achat where nom_achat='" + nom_vente.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteNonQuery();
                if (System.Convert.ToInt32(output) > 0)
                {
                    remplire_grid();
                    RadMessageBox.Show("achat supprimer");

                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }



        }
        public void modifier2()
        {
            string query = $"Update achat set date_achat='{date_vente.Text}', agent_locataire_id=(select user_id from users where username='{agent_drop_down.Text}'), bien_id=(select id_bien from Bien where nom='{Bien_drop_down.Text}'), id_contract=(select id_contract from contracts where nom_contract='{contrat_drop_down.Text}') where nom_achat='{nom_vente.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteNonQuery();

                if (System.Convert.ToInt32(output) > 0)
                {
                    //dataGridView1.Rows.Clear();
                    remplire_grid();
                    RadMessageBox.Show("contrat modifier ");
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("ereur de modification");
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            ajouter2();
        }


        private void rechercher_Click(object sender, EventArgs e)
        {
            Rechercher();
        }

        private void supprimer_Click_1(object sender, EventArgs e)
        {
            supprimer2();
        }

    }
}
