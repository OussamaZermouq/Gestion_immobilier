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
    public partial class consulter_reclamation : Telerik.WinControls.UI.RadForm
    {
        public Connection c;
        public SqlConnection connection;
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public consulter_reclamation()
        {
            InitializeComponent();
        }
        public void remplire_grid()
        {
            dataGridView1.Refresh();
            string query;
            int id_locataire = Login.user_id;
            if (Login.role != "admin")
            {
                query = "select  id_reclamation as numero , description,etat from reclamation where locataire_id=" + id_locataire + "";

            }
            else {
                query = "select  id_reclamation as numero , description,etat from reclamation";
            }
            RadMessageBox.Show(query);
            dt = c.renvoyer_liste_deconnecté(query);
            dataGridView1.DataSource = dt;


        }
        public void supprimer()
        {
            string query = "DELETE  from reclamation where id_reclamation=" + radTextBox1.Text + " ";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteNonQuery();
                if (System.Convert.ToInt32(output) > 0)
                {

                    RadMessageBox.Show("Reclamation supprimer");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["numero"].Value != null &&
                            row.Cells["numero"].Value.ToString() == radTextBox1.Text)
                        {
                            dataGridView1.Rows.Remove(row);
                            break;
                        }
                    }
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
                if (!string.IsNullOrWhiteSpace(radTextBox1.Text))
                {
                    string query = "SELECT * FROM reclamation WHERE id_reclamation LIKE @reclamationId";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {

                        adapter.SelectCommand.Parameters.AddWithValue("@reclamationId", "%" + radTextBox1.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.ClearSelection();
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


        private void consulter_reclamation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supprimrer_Click(object sender, EventArgs e)
        {
            supprimer();
            remplire_grid();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            Rechercher();
            remplire_grid();
        }

        private void consulter_reclamation_Load_1(object sender, EventArgs e)
        {
            etat_drop_down.Items.Add("Resolu");
            etat_drop_down.Items.Add("En attente");
            etat_drop_down.Items.Add("Refuse");
            if (Login.role != "admin")
            {
                etat_drop_down.Enabled = false;
                mod_etat.Enabled = false;
                supprimrer.Enabled = false;
            }
            c = new Connection();
            connection = Connection.Connect_to_db();
            remplire_grid();
        }

        private void mod_etat_Click(object sender, EventArgs e)
        {
            string sql = $"update reclamation set etat ='{etat_drop_down.Text}' where id_reclamation={radTextBox1.Text}";
            c.executer(sql);
        }
    }
}
