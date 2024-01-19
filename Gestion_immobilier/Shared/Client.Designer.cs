namespace Gestion_immobilier.Shared
{
    partial class Client
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.rechercher = new Telerik.WinControls.UI.RadButton();
            this.supprimer = new Telerik.WinControls.UI.RadButton();
            this.modifier = new Telerik.WinControls.UI.RadButton();
            this.ajouter = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.type_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.prenom_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.nom_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.date_naissance_client = new Telerik.WinControls.UI.RadDateTimePicker();
            this.num_tel_client = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissance_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tel_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel1.Location = new System.Drawing.Point(218, 113);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 21);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Nom Client";
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(952, 328);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(112, 28);
            this.rechercher.TabIndex = 23;
            this.rechercher.Text = "Rechercher";
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(777, 328);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 28);
            this.supprimer.TabIndex = 22;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(578, 328);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 28);
            this.modifier.TabIndex = 21;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(402, 328);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 28);
            this.ajouter.TabIndex = 20;
            this.ajouter.Text = "Ajouter";
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(313, 388);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(827, 253);
            this.radGridView1.TabIndex = 19;
            // 
            // type_drop_down
            // 
            this.type_drop_down.DropDownAnimationEnabled = true;
            this.type_drop_down.Location = new System.Drawing.Point(961, 143);
            this.type_drop_down.Name = "type_drop_down";
            this.type_drop_down.Size = new System.Drawing.Size(199, 24);
            this.type_drop_down.TabIndex = 18;
            this.type_drop_down.Text = "-- Choisir le role de cet user --";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(694, 97);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(62, 191);
            this.radSeparator1.TabIndex = 17;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel3.Location = new System.Drawing.Point(218, 242);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(97, 21);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Date naissance";
            // 
            // prenom_input
            // 
            this.prenom_input.Location = new System.Drawing.Point(402, 178);
            this.prenom_input.Name = "prenom_input";
            this.prenom_input.Size = new System.Drawing.Size(199, 24);
            this.prenom_input.TabIndex = 16;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel2.Location = new System.Drawing.Point(218, 178);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 21);
            this.radLabel2.TabIndex = 14;
            this.radLabel2.Text = "Prenom Client";
            // 
            // nom_input
            // 
            this.nom_input.Location = new System.Drawing.Point(402, 113);
            this.nom_input.Name = "nom_input";
            this.nom_input.Size = new System.Drawing.Size(199, 24);
            this.nom_input.TabIndex = 12;
            // 
            // date_naissance_client
            // 
            this.date_naissance_client.CalendarSize = new System.Drawing.Size(290, 320);
            this.date_naissance_client.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_naissance_client.Location = new System.Drawing.Point(402, 242);
            this.date_naissance_client.Name = "date_naissance_client";
            this.date_naissance_client.Size = new System.Drawing.Size(199, 24);
            this.date_naissance_client.TabIndex = 24;
            this.date_naissance_client.TabStop = false;
            this.date_naissance_client.Text = "1/18/2024";
            this.date_naissance_client.Value = new System.DateTime(2024, 1, 18, 3, 4, 24, 903);
            // 
            // num_tel_client
            // 
            this.num_tel_client.Location = new System.Drawing.Point(961, 208);
            this.num_tel_client.Name = "num_tel_client";
            this.num_tel_client.Size = new System.Drawing.Size(199, 24);
            this.num_tel_client.TabIndex = 18;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel5.Location = new System.Drawing.Point(777, 208);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(122, 21);
            this.radLabel5.TabIndex = 17;
            this.radLabel5.Text = "Numero telephone";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel6.Location = new System.Drawing.Point(777, 143);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(72, 21);
            this.radLabel6.TabIndex = 14;
            this.radLabel6.Text = "Type client";
            // 
            // Client
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 722);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.num_tel_client);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.date_naissance_client);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.type_drop_down);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.prenom_input);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.nom_input);
            this.Name = "Client";
            this.Text = "CLient";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenom_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissance_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tel_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadButton rechercher;
        private Telerik.WinControls.UI.RadButton supprimer;
        private Telerik.WinControls.UI.RadButton modifier;
        private Telerik.WinControls.UI.RadButton ajouter;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDropDownList type_drop_down;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButtonTextBox prenom_input;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButtonTextBox nom_input;
        private Telerik.WinControls.UI.RadDateTimePicker date_naissance_client;
        private Telerik.WinControls.UI.RadButtonTextBox num_tel_client;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}
