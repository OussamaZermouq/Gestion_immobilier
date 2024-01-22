using Gestion_immobilier.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Gestion_immobilier.Agent_Immobilier
{
    public partial class AgentMDI : Telerik.WinControls.UI.RadForm
    {
        public AgentMDI()
        {
            InitializeComponent();
        }

        private void AgentMDI_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\oussa\\source\\repos\\Gestion_immobilier\\Gestion_immobilier\\Images\\background.png");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void radMenuButtonItem1_Click(object sender, EventArgs e)
        {
            Bien bien_form = new Bien();
            bien_form.MdiParent = this;
            bien_form.Show();
        }

        private void radMenuButtonItem3_Click(object sender, EventArgs e)
        {
            Vente vente_form = new Vente();
            vente_form.MdiParent = this;
            vente_form.Show();
        }

        private void radMenuButtonItem2_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.MdiParent = this;
            location.Show();
        }

        private void achat_button_ChildrenChanged(object sender, ChildrenChangedEventArgs e)
        {

        }

        private void achat_button_Click(object sender, EventArgs e)
        {
            achat achat = new achat();
            achat.MdiParent = this;
            achat.Show();
        }
    }
}
