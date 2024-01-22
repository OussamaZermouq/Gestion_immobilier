using Gestion_immobilier.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Gestion_immobilier.Admin
{
    public partial class AdminMDI : Telerik.WinControls.UI.RadForm
    {

        public static string theme;

        public AdminMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            Bien bien_form = new Bien();
            bien_form.MdiParent = this;
            bien_form.Show();

        }

        private void AdminMDI_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\oussa\\source\\repos\\Gestion_immobilier\\Gestion_immobilier\\Images\\background.png");
            if (theme == "Aqua")
            {

                this.ThemeName = aquaTheme1.ThemeName;

            }
            else if (theme== "Default")
            {

                this.ThemeName = office2019LightTheme1.ThemeName;

            }
            else if (theme == "Desert")
            {

                this.ThemeName = desertTheme1.ThemeName;

            }
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            Utilisateurs user_form = new Utilisateurs();
            user_form.MdiParent = this;
            user_form.Show();

        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            Client client_form= new Client();
            client_form.MdiParent = this;
            client_form.Show();
        }

        private void radMenuButtonItem4_Click(object sender, EventArgs e)
        {
            Vente vente_form = new Vente();
            vente_form.MdiParent = this;
            vente_form.Show();
        }

        private void radMenuButtonItem5_Click(object sender, EventArgs e)
        {

            Location location = new Location();
            location.MdiParent = this;
            location.Show();
        }

        private void radMenuButtonItem6_Click(object sender, EventArgs e)
        {

        }

        private void radMenuButtonItem7_Click(object sender, EventArgs e)
        {
            consulter_reclamation consulter_Reclamation = new consulter_reclamation();
            consulter_Reclamation.MdiParent = this;
            consulter_Reclamation.Show();
        }

        private void radMenuButtonItem6_Click_1(object sender, EventArgs e)
        {
            this.ThemeName = office2019LightTheme1.ThemeName;
        }

        private void radMenuButtonItem8_Click(object sender, EventArgs e)
        {
            this.ThemeName = desertTheme1.ThemeName;
        }

        private void radMenuButtonItem9_Click(object sender, EventArgs e)
        {
            this.ThemeName = aquaTheme1.ThemeName;
        }

        private void achat_button_Click(object sender, EventArgs e)
        {
            achat achat = new achat();
            achat.MdiParent = this;
            achat.Show();
        }
    }
}
