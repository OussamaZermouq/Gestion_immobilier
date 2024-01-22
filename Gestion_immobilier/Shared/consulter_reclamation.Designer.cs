namespace Gestion_immobilier
{
    partial class consulter_reclamation
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.supprimrer = new Telerik.WinControls.UI.RadButton();
            this.rechercher = new Telerik.WinControls.UI.RadButton();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.office2019LightTheme2 = new Telerik.WinControls.Themes.Office2019LightTheme();
            this.etat_drop_down = new Telerik.WinControls.UI.RadDropDownList();
            this.mod_etat = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.office2019DarkTheme1 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            this.office2019DarkTheme2 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            this.office2019GrayTheme1 = new Telerik.WinControls.Themes.Office2019GrayTheme();
            this.office2019LightTheme3 = new Telerik.WinControls.Themes.Office2019LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etat_drop_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod_etat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(582, 92);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(335, 24);
            this.radTextBox1.TabIndex = 1;
            // 
            // supprimrer
            // 
            this.supprimrer.Location = new System.Drawing.Point(552, 170);
            this.supprimrer.Margin = new System.Windows.Forms.Padding(6);
            this.supprimrer.Name = "supprimrer";
            this.supprimrer.Size = new System.Drawing.Size(165, 32);
            this.supprimrer.TabIndex = 2;
            this.supprimrer.Text = "Supprimer";
            // 
            // rechercher
            // 
            this.rechercher.Location = new System.Drawing.Point(812, 170);
            this.rechercher.Margin = new System.Windows.Forms.Padding(6);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(165, 32);
            this.rechercher.TabIndex = 3;
            this.rechercher.Text = "rechercher";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(697, 64);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(128, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Numero du reclamation:";
            // 
            // etat_drop_down
            // 
            this.etat_drop_down.DropDownAnimationEnabled = true;
            this.etat_drop_down.Location = new System.Drawing.Point(1244, 323);
            this.etat_drop_down.Name = "etat_drop_down";
            this.etat_drop_down.Size = new System.Drawing.Size(170, 24);
            this.etat_drop_down.TabIndex = 5;
            this.etat_drop_down.Text = "-- Choisir etat --";
            // 
            // mod_etat
            // 
            this.mod_etat.Location = new System.Drawing.Point(1244, 401);
            this.mod_etat.Name = "mod_etat";
            this.mod_etat.Size = new System.Drawing.Size(170, 32);
            this.mod_etat.TabIndex = 6;
            this.mod_etat.Text = "Modifier etat";
            this.mod_etat.Click += new System.EventHandler(this.mod_etat_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(1130, 255);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator1.Size = new System.Drawing.Size(76, 275);
            this.radSeparator1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(652, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // consulter_reclamation
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 565);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.mod_etat);
            this.Controls.Add(this.etat_drop_down);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.supprimrer);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consulter_reclamation";
            this.Text = "consulter_reclamation";
            this.ThemeName = "Office2019Light";
            this.Load += new System.EventHandler(this.consulter_reclamation_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etat_drop_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mod_etat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton supprimrer;
        private Telerik.WinControls.UI.RadButton rechercher;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme2;
        private Telerik.WinControls.UI.RadDropDownList etat_drop_down;
        private Telerik.WinControls.UI.RadButton mod_etat;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme1;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme2;
        private Telerik.WinControls.Themes.Office2019GrayTheme office2019GrayTheme1;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme3;
    }
}
