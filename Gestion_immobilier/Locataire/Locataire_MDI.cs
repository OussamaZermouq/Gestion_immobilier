using Gestion_immobilier.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Gestion_immobilier.Locataire
{
    public partial class Locataire_MDI : Telerik.WinControls.UI.RadForm
    {
        public Locataire_MDI()
        {
            InitializeComponent();
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.MdiParent = this;
            location.Show();
        }

        private void Locataire_MDI_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            Ajouter_reclamation ajouter= new Ajouter_reclamation();
            ajouter.MdiParent = this;
            ajouter.Show();
        }
    }
}
