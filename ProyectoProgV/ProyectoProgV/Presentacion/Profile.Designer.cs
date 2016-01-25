namespace ProyectoProgV
{
    partial class Profile
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
            this.btnCargar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTransparente1 = new ProyectoProgV.PanelTransparente();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackgroundImage = global::ProyectoProgV.Properties.Resources.Camera_icon2;
            this.btnCargar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCargar.Location = new System.Drawing.Point(233, 144);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(33, 33);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.UseSelectable = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panelTransparente1
            // 
            this.panelTransparente1.AllowDrop = true;
            this.panelTransparente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransparente1.Location = new System.Drawing.Point(53, 80);
            this.panelTransparente1.Name = "panelTransparente1";
            this.panelTransparente1.Size = new System.Drawing.Size(160, 168);
            this.panelTransparente1.TabIndex = 2;
            this.panelTransparente1.Click += new System.EventHandler(this.panelTransparente1_Click);
            this.panelTransparente1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransparente1_DragDrop);
            this.panelTransparente1.DragOver += new System.Windows.Forms.DragEventHandler(this.panelTransparente1_DragOver);
            this.panelTransparente1.MouseEnter += new System.EventHandler(this.panelTransparente1_MouseEnter);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("MS Reference Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(39, 255);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 33);
            this.lblUser.TabIndex = 3;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 462);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelTransparente1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Resizable = false;
            this.Text = "Perfil Usuario";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnCargar;
        private PanelTransparente panelTransparente1;
        private System.Windows.Forms.Label lblUser;
    }
}