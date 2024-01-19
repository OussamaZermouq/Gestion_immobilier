using Gestion_immobilier.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Pivot.Core.Olap;
using Telerik.WinControls;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace Gestion_immobilier.Shared
{
    public partial class Bien : Telerik.WinControls.UI.RadForm
    {
        Connection connection = null;

        public DataTable Dt;
        public Bien()
        {
            InitializeComponent();
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Bien_Load(object sender, EventArgs e)
        {

            connection = new Connection();
            remplir_combobox_prop();
            remplir_dgv();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ImportPhoto();
        }

        private void ajouter_button_Click(object sender, EventArgs e)
        {
            if (Adresseinput.Text=="" || codep.Text == "" || VilleInput.Text == "" || nom_input.Text == "" || tailleinput.Text == "" || propcombobox.SelectedItem.ToString() == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                string localisation = $"'{Adresseinput.Text} {codep.Text} {VilleInput.Text}'";
                string sql = $"Insert into Bien values ('{nom_input.Text}',{localisation},{tailleinput.Text},'{DescriptionInput.Text}', (select user_id from users where username = '{propcombobox.SelectedItem.ToString()}') )";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Bien ajouter avec succès!");
                }
                else
                {
                    RadMessageBox.Show("Une erreur est survenue veuillez reessayer plus tard");
                }
            }
            remplir_dgv();


        }
        public void remplir_combobox_prop()
        {

            SqlDataReader dr = connection.renvoyer_Data_Reader("select username from users where role ='Proprietere'");
            while (dr.Read())
            {
                propcombobox.Items.Add(dr.GetValue(0).ToString());
            }
            //to prevent crashes when reloading the form
            dr.Close();

        }
        public void remplir_dgv()
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté("Select b.*, username from Bien b join users u on b.proprietaire=u.user_id");
            radGridView1.DataSource = Dt;
        }

        private void modifier_button_Click(object sender, EventArgs e)
        {
            if (Adresseinput.Text == "" || codep.Text == "" || VilleInput.Text == "" || nom_input.Text == "" || tailleinput.Text == "" || propcombobox.SelectedItem.ToString() == "")
            {
                RadMessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                string localisation = $"'{Adresseinput.Text} {codep.Text} {VilleInput.Text}'";
                string sql = $"Update bien set localisation={localisation}, taille ={tailleinput.Text}, caracteristique = '{DescriptionInput.Text}',proprietaire = (select user_id from users where username = '{propcombobox.SelectedItem.ToString()}') where nom = '{nom_input.Text}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Bien modifier avec succès!");
                }
                else
                {
                    RadMessageBox.Show("Une erreur est survenue veuillez reessayer plus tard");
                }
            }
            remplir_dgv();
        }

        private void supprimer_button_Click(object sender, EventArgs e)
        {
            if (nom_input.Text == "")
            {
                RadMessageBox.Show("Veuillez remplir le nom de la propriété");
            }
            else
            {
                string sql = $"delete bien where nom='{nom_input}'";
                if (connection.executer(sql) > 0)
                {
                    RadMessageBox.Show("Bien supprimer avec succès!");
                }
                else
                {
                    RadMessageBox.Show("Une erreur est survenue veuillez reessayer plus tard");
                }
            }
            remplir_dgv();

        }

        private void rechercher_button_Click(object sender, EventArgs e)
        {
            radGridView1.Refresh();
            Dt = connection.renvoyer_liste_deconnecté($"Select b.*, username from Bien b join users u on b.proprietaire=u.user_id and nom= '{nom_input}'");
            radGridView1.DataSource = Dt;

        }
        public string[] ImportPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.Filter = "Image Files (.jpg;.jpeg; .png;.gif; .bmp)|.jpg; .jpeg;.png; .gif;.bmp|All Files (*.*)|*.*";

            openFileDialog.Title = "Veuillez choisir des photos";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFilePath = openFileDialog.FileNames;
                foreach (var file in selectedFilePath)
                {
                    var output = connection.executer($"Insert into reclamation_photos values ('{file}')");

                }

                return selectedFilePath;
            }
            else
            {
                return null; // User canceled the operation
            }


        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
