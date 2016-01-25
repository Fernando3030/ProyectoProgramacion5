namespace ProyectoProgV
{
    partial class SalidaProductos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtProducto = new MetroFramework.Controls.MetroTextBox();
            this.panelCentral = new MetroFramework.Controls.MetroPanel();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioC = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioV = new MetroFramework.Controls.MetroTextBox();
            this.txtRetirar = new System.Windows.Forms.Label();
            this.txtRecibir = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.panelOpciones = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvanzar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelCentral.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(17, 33);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(116, 29);
            this.txtCodigo.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseCustomForeColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.UseStyleColors = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(164, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 21);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProducto.Lines = new string[0];
            this.txtProducto.Location = new System.Drawing.Point(168, 33);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(136, 29);
            this.txtProducto.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtProducto.TabIndex = 9;
            this.txtProducto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProducto.UseCustomBackColor = true;
            this.txtProducto.UseCustomForeColor = true;
            this.txtProducto.UseSelectable = true;
            this.txtProducto.UseStyleColors = true;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral.Controls.Add(this.date);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.txtPrecioC);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.txtPrecioV);
            this.panelCentral.Controls.Add(this.txtRetirar);
            this.panelCentral.Controls.Add(this.txtRecibir);
            this.panelCentral.Controls.Add(this.lblCategoria);
            this.panelCentral.Controls.Add(this.txtProducto);
            this.panelCentral.Controls.Add(this.lblCodigo);
            this.panelCentral.Controls.Add(this.txtCodigo);
            this.panelCentral.HorizontalScrollbarBarColor = true;
            this.panelCentral.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCentral.HorizontalScrollbarSize = 10;
            this.panelCentral.Location = new System.Drawing.Point(27, 109);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(324, 191);
            this.panelCentral.Style = MetroFramework.MetroColorStyle.Blue;
            this.panelCentral.TabIndex = 15;
            this.panelCentral.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panelCentral.UseCustomBackColor = true;
            this.panelCentral.UseCustomForeColor = true;
            this.panelCentral.UseStyleColors = true;
            this.panelCentral.VerticalScrollbarBarColor = true;
            this.panelCentral.VerticalScrollbarHighlightOnWheel = false;
            this.panelCentral.VerticalScrollbarSize = 10;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(172, 91);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(132, 29);
            this.date.Style = MetroFramework.MetroColorStyle.Brown;
            this.date.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio Compra:";
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioC.Lines = new string[0];
            this.txtPrecioC.Location = new System.Drawing.Point(168, 148);
            this.txtPrecioC.MaxLength = 32767;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.PasswordChar = '\0';
            this.txtPrecioC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioC.SelectedText = "";
            this.txtPrecioC.Size = new System.Drawing.Size(136, 29);
            this.txtPrecioC.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtPrecioC.TabIndex = 15;
            this.txtPrecioC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioC.UseCustomBackColor = true;
            this.txtPrecioC.UseCustomForeColor = true;
            this.txtPrecioC.UseSelectable = true;
            this.txtPrecioC.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio Venta:";
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioV.Lines = new string[0];
            this.txtPrecioV.Location = new System.Drawing.Point(17, 148);
            this.txtPrecioV.MaxLength = 32767;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.PasswordChar = '\0';
            this.txtPrecioV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioV.SelectedText = "";
            this.txtPrecioV.Size = new System.Drawing.Size(116, 29);
            this.txtPrecioV.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtPrecioV.TabIndex = 13;
            this.txtPrecioV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioV.UseCustomBackColor = true;
            this.txtPrecioV.UseCustomForeColor = true;
            this.txtPrecioV.UseSelectable = true;
            this.txtPrecioV.UseStyleColors = true;
            // 
            // txtRetirar
            // 
            this.txtRetirar.AutoSize = true;
            this.txtRetirar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetirar.Location = new System.Drawing.Point(13, 65);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(57, 21);
            this.txtRetirar.TabIndex = 10;
            this.txtRetirar.Text = "Retirar";
            // 
            // txtRecibir
            // 
            this.txtRecibir.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRecibir.Lines = new string[0];
            this.txtRecibir.Location = new System.Drawing.Point(17, 89);
            this.txtRecibir.MaxLength = 32767;
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.PasswordChar = '\0';
            this.txtRecibir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecibir.SelectedText = "";
            this.txtRecibir.Size = new System.Drawing.Size(116, 29);
            this.txtRecibir.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtRecibir.TabIndex = 11;
            this.txtRecibir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecibir.UseCustomBackColor = true;
            this.txtRecibir.UseCustomForeColor = true;
            this.txtRecibir.UseSelectable = true;
            this.txtRecibir.UseStyleColors = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAceptar.Highlight = true;
            this.btnAceptar.Location = new System.Drawing.Point(13, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.metroToolTip1.SetToolTip(this.btnAceptar, "Nuevo Proveedor");
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            // 
            // btnSalir
            // 
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Highlight = true;
            this.btnSalir.Location = new System.Drawing.Point(101, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.metroToolTip1.SetToolTip(this.btnSalir, "Salir ");
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseCustomForeColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpciones.Controls.Add(this.btnSalir);
            this.panelOpciones.Controls.Add(this.btnAceptar);
            this.panelOpciones.HorizontalScrollbarBarColor = true;
            this.panelOpciones.HorizontalScrollbarHighlightOnWheel = false;
            this.panelOpciones.HorizontalScrollbarSize = 10;
            this.panelOpciones.Location = new System.Drawing.Point(96, 306);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(191, 56);
            this.panelOpciones.TabIndex = 21;
            this.panelOpciones.VerticalScrollbarBarColor = true;
            this.panelOpciones.VerticalScrollbarHighlightOnWheel = false;
            this.panelOpciones.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Registro de Salida de Productos";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackgroundImage = global::ProyectoProgV.Properties.Resources.arrow2;
            this.btnAvanzar.Location = new System.Drawing.Point(319, 65);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(33, 33);
            this.btnAvanzar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAvanzar.TabIndex = 25;
            this.btnAvanzar.UseCustomBackColor = true;
            this.btnAvanzar.UseCustomForeColor = true;
            this.btnAvanzar.UseSelectable = true;
            this.btnAvanzar.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ProyectoProgV.Properties.Resources.arrow3;
            this.metroButton1.Location = new System.Drawing.Point(282, 65);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(33, 33);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 24;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // SalidaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 372);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelCentral);
            this.MaximizeBox = false;
            this.Name = "SalidaProductos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Salida De Productos";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private MetroFramework.Controls.MetroTextBox txtProducto;
        private MetroFramework.Controls.MetroPanel panelCentral;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroPanel panelOpciones;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtPrecioC;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPrecioV;
        private System.Windows.Forms.Label txtRetirar;
        private MetroFramework.Controls.MetroTextBox txtRecibir;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnAvanzar;
    }
}