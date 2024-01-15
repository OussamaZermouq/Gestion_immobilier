namespace Gestion_immobilier
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.password_input = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.office2019LightTheme1 = new Telerik.WinControls.Themes.Office2019LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.username_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // username_input
            // 
            this.username_input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_input.Location = new System.Drawing.Point(135, 150);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(194, 27);
            this.username_input.TabIndex = 0;
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_input.Location = new System.Drawing.Point(135, 219);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(194, 27);
            this.password_input.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(135, 126);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Username";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(135, 195);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Password";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(135, 274);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(124, 18);
            this.radCheckBox1.TabIndex = 6;
            this.radCheckBox1.Text = "Reserver ma session";
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radPictureBox1.BackgroundImage")));
            this.radPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radPictureBox1.DefaultImage = ((System.Drawing.Image)(resources.GetObject("radPictureBox1.DefaultImage")));
            this.radPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("radPictureBox1.Image")));
            this.radPictureBox1.ImageLayout = Telerik.WinControls.UI.RadImageLayout.FitIntoBounds;
            this.radPictureBox1.Location = new System.Drawing.Point(497, 32);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(261, 450);
            this.radPictureBox1.TabIndex = 7;
            this.radPictureBox1.ImageLoaded += new System.EventHandler(this.radPictureBox1_ImageLoaded);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(135, 314);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Login";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(135, 344);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 9;
            this.radButton2.Text = "Annuler";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radPictureBox1);
            this.Controls.Add(this.radCheckBox1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Login";
            this.Text = "";
            this.ThemeName = "Office2019Light";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.username_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButtonTextBox username_input;
        private Telerik.WinControls.UI.RadButtonTextBox password_input;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.Themes.Office2019LightTheme office2019LightTheme1;
    }
}
