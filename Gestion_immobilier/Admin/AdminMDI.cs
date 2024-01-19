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
    }
}
