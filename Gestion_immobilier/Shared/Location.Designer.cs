namespace Gestion_immobilier.Shared
{
    partial class Location
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
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
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
            this.date_location_debut = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.nom_location = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.office2019LightTheme2 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.date_location_fin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.locataire_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.date_location_debut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_location_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locataire_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(275, 413);
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
            this.rechercher.Location = new System.Drawing.Point(831, 332);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(112, 28);
            this.rechercher.TabIndex = 31;
            this.rechercher.Text = "Rechercher";
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(656, 332);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 28);
            this.supprimer.TabIndex = 30;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(457, 332);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 28);
            this.modifier.TabIndex = 29;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(281, 332);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 28);
            this.ajouter.TabIndex = 28;
            this.ajouter.Text = "Ajouter";
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // contrat_drop_down
            // 
            this.contrat_drop_down.DropDownAnimationEnabled = true;
            this.contrat_drop_down.Location = new System.Drawing.Point(833, 225);
            this.contrat_drop_down.Name = "contrat_drop_down";
            this.contrat_drop_down.Size = new System.Drawing.Size(172, 24);
            this.contrat_drop_down.TabIndex = 27;
            this.contrat_drop_down.Text = "-- Chosir le contrat --";
            // 
            // Bien_drop_down
            // 
            this.Bien_drop_down.DropDownAnimationEnabled = true;
            this.Bien_drop_down.Location = new System.Drawing.Point(833, 173);
            this.Bien_drop_down.Name = "Bien_drop_down";
            this.Bien_drop_down.Size = new System.Drawing.Size(172, 24);
            this.Bien_drop_down.TabIndex = 26;
            this.Bien_drop_down.Text = "-- Chosir le bien a louer --";
            // 
            // agent_drop_down
            // 
            this.agent_drop_down.DropDownAnimationEnabled = true;
            this.agent_drop_down.Location = new System.Drawing.Point(833, 121);
            this.agent_drop_down.Name = "agent_drop_down";
            this.agent_drop_down.Size = new System.Drawing.Size(172, 24);
            this.agent_drop_down.TabIndex = 25;
            this.agent_drop_down.Text = "-- Chosir l\'agent --";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(680, 231);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(44, 18);
            this.radLabel5.TabIndex = 24;
            this.radLabel5.Text = "Contrat";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(680, 179);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(28, 18);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "Bien";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(680, 127);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(85, 18);
            this.radLabel3.TabIndex = 22;
            this.radLabel3.Text = "Agent Locataire";
            // 
            // date_location_debut
            // 
            this.date_location_debut.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_location_debut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_location_debut.Location = new System.Drawing.Point(379, 154);
            this.date_location_debut.Name = "date_location_debut";
            this.date_location_debut.Size = new System.Drawing.Size(164, 24);
            this.date_location_debut.TabIndex = 21;
            this.date_location_debut.TabStop = false;
            this.date_location_debut.Text = "1/18/2024";
            this.date_location_debut.Value = new System.DateTime(2024, 1, 18, 16, 48, 8, 17);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(590, 53);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(50, 249);
            this.radSeparator1.TabIndex = 20;
            // 
            // nom_location
            // 
            this.nom_location.Location = new System.Drawing.Point(379, 96);
            this.nom_location.Name = "nom_location";
            this.nom_location.Size = new System.Drawing.Size(164, 24);
            this.nom_location.TabIndex = 19;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(252, 160);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(122, 18);
            this.radLabel2.TabIndex = 18;
            this.radLabel2.Text = "Date Debut de location";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(252, 102);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(77, 18);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "Nom Location";
            // 
            // date_location_fin
            // 
            this.date_location_fin.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_location_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_location_fin.Location = new System.Drawing.Point(379, 218);
            this.date_location_fin.Name = "date_location_fin";
            this.date_location_fin.Size = new System.Drawing.Size(164, 24);
            this.date_location_fin.TabIndex = 23;
            this.date_location_fin.TabStop = false;
            this.date_location_fin.Text = "1/18/2024";
            this.date_location_fin.Value = new System.DateTime(2024, 1, 18, 16, 48, 8, 17);
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(252, 224);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(104, 18);
            this.radLabel6.TabIndex = 22;
            this.radLabel6.Text = "Date fin de location";
            // 
            // locataire_drop_down
            // 
            this.locataire_drop_down.DropDownAnimationEnabled = true;
            this.locataire_drop_down.Location = new System.Drawing.Point(833, 65);
            this.locataire_drop_down.Name = "locataire_drop_down";
            this.locataire_drop_down.Size = new System.Drawing.Size(172, 24);
            this.locataire_drop_down.TabIndex = 34;
            this.locataire_drop_down.Text = "-- Chosir locataire --";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(680, 71);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(51, 18);
            this.radLabel7.TabIndex = 33;
            this.radLabel7.Text = "Locataire";
            // 
            // Location
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 703);
            this.Controls.Add(this.locataire_drop_down);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.date_location_fin);
            this.Controls.Add(this.radLabel6);
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
            this.Controls.Add(this.date_location_debut);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.nom_location);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "Location";
            this.Text = "Location";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.Location_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.date_location_debut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_location_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locataire_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
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
        private Telerik.WinControls.UI.RadDateTimePicker date_location_debut;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadTextBox nom_location;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme2;
        private Telerik.WinControls.UI.RadDateTimePicker date_location_fin;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDropDownList locataire_drop_down;
        private Telerik.WinControls.UI.RadLabel radLabel7;
    }
}
