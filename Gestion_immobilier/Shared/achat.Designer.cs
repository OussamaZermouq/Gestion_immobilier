namespace Gestion_immobilier
{
    partial class achat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.rechercher = new Telerik.WinControls.UI.RadButton();
            this.supprimer = new Telerik.WinControls.UI.RadButton();
            this.modifier = new Telerik.WinControls.UI.RadButton();
            this.ajouter = new Telerik.WinControls.UI.RadButton();
            this.contrat_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.Bien_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.agent_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.date_vente = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.nom_vente = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrat_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bien_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_vente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_vente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(348, 363);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(730, 247);
            this.radGridView1.TabIndex = 32;
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(904, 282);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(112, 28);
            this.rechercher.TabIndex = 31;
            this.rechercher.Text = "Rechercher";
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(729, 282);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 28);
            this.supprimer.TabIndex = 30;
            this.supprimer.Text = "Supprimer";
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(530, 282);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 28);
            this.modifier.TabIndex = 29;
            this.modifier.Text = "Modifier";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(354, 282);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 28);
            this.ajouter.TabIndex = 28;
            this.ajouter.Text = "Ajouter";
            // 
            // contrat_drop_down
            // 
            this.contrat_drop_down.DropDownAnimationEnabled = true;
            this.contrat_drop_down.Location = new System.Drawing.Point(906, 175);
            this.contrat_drop_down.Name = "contrat_drop_down";
            this.contrat_drop_down.Size = new System.Drawing.Size(172, 24);
            this.contrat_drop_down.TabIndex = 27;
            this.contrat_drop_down.Text = "-- Chosir le contrat --";
            // 
            // Bien_drop_down
            // 
            this.Bien_drop_down.DropDownAnimationEnabled = true;
            this.Bien_drop_down.Location = new System.Drawing.Point(906, 123);
            this.Bien_drop_down.Name = "Bien_drop_down";
            this.Bien_drop_down.Size = new System.Drawing.Size(172, 24);
            this.Bien_drop_down.TabIndex = 26;
            this.Bien_drop_down.Text = "-- Chosir le bien a louer --";
            // 
            // agent_drop_down
            // 
            this.agent_drop_down.DropDownAnimationEnabled = true;
            this.agent_drop_down.Location = new System.Drawing.Point(906, 71);
            this.agent_drop_down.Name = "agent_drop_down";
            this.agent_drop_down.Size = new System.Drawing.Size(172, 24);
            this.agent_drop_down.TabIndex = 25;
            this.agent_drop_down.Text = "-- Chosir l\'agent --";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(753, 181);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 18);
            this.radLabel5.TabIndex = 23;
            this.radLabel5.Text = "Contrat";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(753, 129);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(28, 18);
            this.radLabel4.TabIndex = 24;
            this.radLabel4.Text = "Bien";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(753, 77);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(85, 18);
            this.radLabel3.TabIndex = 22;
            this.radLabel3.Text = "Agent Locataire";
            // 
            // date_vente
            // 
            this.date_vente.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_vente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_vente.Location = new System.Drawing.Point(446, 148);
            this.date_vente.Name = "date_vente";
            this.date_vente.Size = new System.Drawing.Size(164, 24);
            this.date_vente.TabIndex = 21;
            this.date_vente.TabStop = false;
            this.date_vente.Text = "1/18/2024";
            this.date_vente.Value = new System.DateTime(2024, 1, 18, 16, 48, 8, 17);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(663, 31);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(50, 186);
            this.radSeparator1.TabIndex = 20;
            // 
            // nom_vente
            // 
            this.nom_vente.Location = new System.Drawing.Point(446, 71);
            this.nom_vente.Name = "nom_vente";
            this.nom_vente.Size = new System.Drawing.Size(164, 24);
            this.nom_vente.TabIndex = 19;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(319, 154);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 18);
            this.radLabel2.TabIndex = 18;
            this.radLabel2.Text = "Date vente";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(319, 77);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "Nom vente";
            // 
            // achat
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 770);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.contrat_drop_down);
            this.Controls.Add(this.Bien_drop_down);
            this.Controls.Add(this.agent_drop_down);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.date_vente);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.nom_vente);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "achat";
            this.Text = "achat";
            this.ThemeName = "Office2019Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrat_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bien_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agent_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_vente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_vente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton rechercher;
        private Telerik.WinControls.UI.RadButton supprimer;
        private Telerik.WinControls.UI.RadButton modifier;
        private Telerik.WinControls.UI.RadButton ajouter;
        private Telerik.WinControls.UI.RadDropDownList contrat_drop_down;
        private Telerik.WinControls.UI.RadDropDownList Bien_drop_down;
        private Telerik.WinControls.UI.RadDropDownList agent_drop_down;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker date_vente;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadTextBox nom_vente;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
    }
}
