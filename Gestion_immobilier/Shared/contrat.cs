using Gestion_immobilier.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using Telerik.WinControls.UI;

namespace Gestion_immobilier
{
    public partial class contrat : Telerik.WinControls.UI.RadForm
    {
        public SqlConnection connection;
        public SqlDataReader dr;
        public DataTable dt = new DataTable();



        public contrat()
        {
            InitializeComponent();
        }
        public void remplire_grid()
        {

            int id_locataire = Login.user_id;
            string query = "select  * from contracts ";
            SqlCommand cmd = new SqlCommand(query, connection);
            dr = cmd.ExecuteReader();
            dt.Clear();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();

        }
        public void supprimer()
        {
            string query = "DELETE  from contracts where id_contract=" + radTextBox3.Text + " ";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteNonQuery();
                if (System.Convert.ToInt32(output) > 0)
                {
                    remplire_grid();
                    RadMessageBox.Show("Reclamation supprimer");

                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }



        }
        public void ajouter()
        {
            string query = "insert into contracts values ('" + radTextBox1.Text + "','" + radTextBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                object output = cmd.ExecuteNonQuery();

                if (System.Convert.ToInt32(output) > 0)
                {
                    //dataGridView1.Rows.Clear();
                    remplire_grid();
                    RadMessageBox.Show("contrat ajouter ");
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show("ereur dajoute");
            }
        }
        public void modifier()
        {
            string query = "update contracts set nom_contract=' " + radTextBox1.Text + "', filename_contract ='" + radTextBox2.Text + "' where id_contract =" + radTextBox3.Text + " ";
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
        private void Rechercher()
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(radTextBox1.Text))
                {
                    string query = "SELECT * FROM contracts WHERE nom_contract LIKE @contractid";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {

                        adapter.SelectCommand.Parameters.AddWithValue("@contractid", "" + radTextBox1.Text + "%");
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


        private void contrat_Load(object sender, EventArgs e)
        {
            connection = Connection.Connect_to_db();
            remplire_grid();
            radTextBox3.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Rechercher();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            ajouter();
            dataGridView1.Refresh();

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                radTextBox3.Text = row.Cells[0].Value.ToString();
                radTextBox1.Text = row.Cells[1].Value.ToString();
                radTextBox2.Text = row.Cells[2].Value.ToString();

            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            modifier();
        }
    }
}
