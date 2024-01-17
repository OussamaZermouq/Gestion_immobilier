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

        }
    }
}
