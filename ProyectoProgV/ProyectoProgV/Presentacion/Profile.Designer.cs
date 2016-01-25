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
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTransparente1 = new ProyectoProgV.PanelTransparente();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackgroundImage = global::ProyectoProgV.Properties.Resources.Camera_icon2;
            this.btnCargar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCargar.Location = new System.Drawing.Point(240, 27);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(33, 33);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.UseSelectable = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("MS Reference Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Chocolate;
            this.lblUser.Location = new System.Drawing.Point(115, 118);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 33);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "fdfdf";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(19, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 336);
            this.panel1.TabIndex = 4;
            // 
            // panelTransparente1
            // 
            this.panelTransparente1.AllowDrop = true;
            this.panelTransparente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransparente1.Location = new System.Drawing.Point(83, 63);
            this.panelTransparente1.Name = "panelTransparente1";
            this.panelTransparente1.Size = new System.Drawing.Size(160, 168);
            this.panelTransparente1.TabIndex = 2;
            this.panelTransparente1.Click += new System.EventHandler(this.panelTransparente1_Click);
            this.panelTransparente1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransparente1_DragDrop);
            this.panelTransparente1.DragOver += new System.Windows.Forms.DragEventHandler(this.panelTransparente1_DragOver);
            this.panelTransparente1.MouseEnter += new System.EventHandler(this.panelTransparente1_MouseEnter);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTransparente1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Perfil Usuario";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnCargar;
        private PanelTransparente panelTransparente1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
    }
}