namespace Gestion_immobilier.Admin
{
    partial class Utilisateurs
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
            this.username_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.password_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.pasword_retype_password = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.role_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.ajouter = new Telerik.WinControls.UI.RadButton();
            this.modifier = new Telerik.WinControls.UI.RadButton();
            this.supprimer = new Telerik.WinControls.UI.RadButton();
            this.rechercher = new Telerik.WinControls.UI.RadButton();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.theme_choose = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasword_retype_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_choose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel1.Location = new System.Drawing.Point(120, 82);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Username";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(304, 82);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(199, 24);
            this.username_input.TabIndex = 1;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(304, 147);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(199, 24);
            this.password_input.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel2.Location = new System.Drawing.Point(120, 147);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(89, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Mot de passe";
            // 
            // pasword_retype_password
            // 
            this.pasword_retype_password.Location = new System.Drawing.Point(304, 211);
            this.pasword_retype_password.Name = "pasword_retype_password";
            this.pasword_retype_password.Size = new System.Drawing.Size(199, 24);
            this.pasword_retype_password.TabIndex = 3;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLabel3.Location = new System.Drawing.Point(120, 211);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(163, 21);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Re-entrer le mot de passe";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(596, 66);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(62, 191);
            this.radSeparator1.TabIndex = 4;
            // 
            // role_drop_down
            // 
            this.role_drop_down.DropDownAnimationEnabled = true;
            this.role_drop_down.Location = new System.Drawing.Point(728, 147);
            this.role_drop_down.Name = "role_drop_down";
            this.role_drop_down.Size = new System.Drawing.Size(238, 24);
            this.role_drop_down.TabIndex = 5;
            this.role_drop_down.Text = "-- Choisir le role de cet user --";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(304, 357);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(662, 236);
            this.radGridView1.TabIndex = 6;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(304, 297);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(112, 28);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter";
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(480, 297);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(112, 28);
            this.modifier.TabIndex = 8;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(679, 297);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(112, 28);
            this.supprimer.TabIndex = 9;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(854, 297);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(112, 28);
            this.rechercher.TabIndex = 10;
            this.rechercher.Text = "Rechercher";
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // theme_choose
            // 
            this.theme_choose.DropDownAnimationEnabled = true;
            this.theme_choose.Location = new System.Drawing.Point(1087, 12);
            this.theme_choose.Name = "theme_choose";
            this.theme_choose.Size = new System.Drawing.Size(161, 24);
            this.theme_choose.TabIndex = 11;
            this.theme_choose.Text = "Theme Chooser";
            this.theme_choose.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.theme_choose_SelectedIndexChanged);
            // 
            // Utilisateurs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 646);
            this.Controls.Add(this.theme_choose);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.role_drop_down);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.pasword_retype_password);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.radLabel1);
            this.Name = "Utilisateurs";
            this.Text = "Utilisateurs";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.Utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasword_retype_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_choose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButtonTextBox username_input;
        private Telerik.WinControls.UI.RadButtonTextBox password_input;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButtonTextBox pasword_retype_password;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadDropDownList role_drop_down;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton ajouter;
        private Telerik.WinControls.UI.RadButton modifier;
        private Telerik.WinControls.UI.RadButton supprimer;
        private Telerik.WinControls.UI.RadButton rechercher;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadDropDownList theme_choose;
    }
}
