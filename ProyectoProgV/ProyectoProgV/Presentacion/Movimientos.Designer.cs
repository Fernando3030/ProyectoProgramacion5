namespace ProyectoProgV
{
    partial class EntradaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtProducto = new MetroFramework.Controls.MetroTextBox();
            this.panelCentral = new MetroFramework.Controls.MetroPanel();
            this.rbSalida = new MetroFramework.Controls.MetroRadioButton();
            this.rbEntrada = new MetroFramework.Controls.MetroRadioButton();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioC = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioV = new MetroFramework.Controls.MetroTextBox();
            this.txtRecibirRetirar = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.panelOpciones = new MetroFramework.Controls.MetroPanel();
            this.btnAvanzar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView = new MetroFramework.Controls.MetroGrid();
            this.txtBusqueda = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(17, 33);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(140, 29);
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
            this.lblCategoria.Location = new System.Drawing.Point(182, 8);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 21);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.Enabled = false;
            this.txtProducto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProducto.Lines = new string[0];
            this.txtProducto.Location = new System.Drawing.Point(186, 32);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducto.SelectedText = "";
            this.txtProducto.Size = new System.Drawing.Size(155, 29);
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
            this.panelCentral.Controls.Add(this.rbSalida);
            this.panelCentral.Controls.Add(this.rbEntrada);
            this.panelCentral.Controls.Add(this.date);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.txtPrecioC);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.txtPrecioV);
            this.panelCentral.Controls.Add(this.txtRecibirRetirar);
            this.panelCentral.Controls.Add(this.lblCategoria);
            this.panelCentral.Controls.Add(this.txtProducto);
            this.panelCentral.Controls.Add(this.lblCodigo);
            this.panelCentral.Controls.Add(this.txtCodigo);
            this.panelCentral.HorizontalScrollbarBarColor = true;
            this.panelCentral.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCentral.HorizontalScrollbarSize = 10;
            this.panelCentral.Location = new System.Drawing.Point(27, 109);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(360, 191);
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
            // rbSalida
            // 
            this.rbSalida.AutoSize = true;
            this.rbSalida.BackColor = System.Drawing.Color.LightGray;
            this.rbSalida.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbSalida.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbSalida.Location = new System.Drawing.Point(98, 67);
            this.rbSalida.Name = "rbSalida";
            this.rbSalida.Size = new System.Drawing.Size(66, 19);
            this.rbSalida.Style = MetroFramework.MetroColorStyle.Brown;
            this.rbSalida.TabIndex = 30;
            this.rbSalida.Text = "Salida";
            this.rbSalida.UseSelectable = true;
            this.rbSalida.CheckedChanged += new System.EventHandler(this.rbSalida_CheckedChanged);
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.BackColor = System.Drawing.Color.LightGray;
            this.rbEntrada.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbEntrada.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbEntrada.Location = new System.Drawing.Point(16, 67);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(76, 19);
            this.rbEntrada.Style = MetroFramework.MetroColorStyle.Brown;
            this.rbEntrada.TabIndex = 29;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseSelectable = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(187, 90);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(154, 29);
            this.date.Style = MetroFramework.MetroColorStyle.Brown;
            this.date.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio Compra:";
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.BackColor = System.Drawing.Color.White;
            this.txtPrecioC.Enabled = false;
            this.txtPrecioC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioC.Lines = new string[0];
            this.txtPrecioC.Location = new System.Drawing.Point(186, 147);
            this.txtPrecioC.MaxLength = 32767;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.PasswordChar = '\0';
            this.txtPrecioC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioC.SelectedText = "";
            this.txtPrecioC.Size = new System.Drawing.Size(155, 29);
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
            this.txtPrecioV.BackColor = System.Drawing.Color.White;
            this.txtPrecioV.Enabled = false;
            this.txtPrecioV.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecioV.Lines = new string[0];
            this.txtPrecioV.Location = new System.Drawing.Point(17, 148);
            this.txtPrecioV.MaxLength = 32767;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.PasswordChar = '\0';
            this.txtPrecioV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioV.SelectedText = "";
            this.txtPrecioV.Size = new System.Drawing.Size(140, 29);
            this.txtPrecioV.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtPrecioV.TabIndex = 13;
            this.txtPrecioV.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioV.UseCustomBackColor = true;
            this.txtPrecioV.UseCustomForeColor = true;
            this.txtPrecioV.UseSelectable = true;
            this.txtPrecioV.UseStyleColors = true;
            // 
            // txtRecibirRetirar
            // 
            this.txtRecibirRetirar.BackColor = System.Drawing.Color.White;
            this.txtRecibirRetirar.Enabled = false;
            this.txtRecibirRetirar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRecibirRetirar.Lines = new string[0];
            this.txtRecibirRetirar.Location = new System.Drawing.Point(17, 89);
            this.txtRecibirRetirar.MaxLength = 32767;
            this.txtRecibirRetirar.Name = "txtRecibirRetirar";
            this.txtRecibirRetirar.PasswordChar = '\0';
            this.txtRecibirRetirar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecibirRetirar.SelectedText = "";
            this.txtRecibirRetirar.Size = new System.Drawing.Size(140, 29);
            this.txtRecibirRetirar.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtRecibirRetirar.TabIndex = 11;
            this.txtRecibirRetirar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecibirRetirar.UseCustomBackColor = true;
            this.txtRecibirRetirar.UseCustomForeColor = true;
            this.txtRecibirRetirar.UseSelectable = true;
            this.txtRecibirRetirar.UseStyleColors = true;
            this.txtRecibirRetirar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibirRetirar_KeyPress);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
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
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // btnAvanzar
            // 
            this.btnAvanzar.BackgroundImage = global::ProyectoProgV.Properties.Resources.arrow2;
            this.btnAvanzar.Location = new System.Drawing.Point(805, 70);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(34, 33);
            this.btnAvanzar.TabIndex = 25;
            this.btnAvanzar.UseCustomBackColor = true;
            this.btnAvanzar.UseCustomForeColor = true;
            this.btnAvanzar.UseSelectable = true;
            this.btnAvanzar.UseStyleColors = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ProyectoProgV.Properties.Resources.arrow3;
            this.metroButton1.Location = new System.Drawing.Point(764, 70);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 33);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 24;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(393, 109);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(460, 253);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.UseCustomBackColor = true;
            this.dataGridView.UseCustomForeColor = true;
            this.dataGridView.UseStyleColors = true;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBusqueda.Lines = new string[0];
            this.txtBusqueda.Location = new System.Drawing.Point(588, 75);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.Size = new System.Drawing.Size(155, 29);
            this.txtBusqueda.Style = MetroFramework.MetroColorStyle.Brown;
            this.txtBusqueda.TabIndex = 27;
            this.txtBusqueda.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusqueda.UseCustomBackColor = true;
            this.txtBusqueda.UseCustomForeColor = true;
            this.txtBusqueda.UseSelectable = true;
            this.txtBusqueda.UseStyleColors = true;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Búsqueda por Producto:";
            // 
            // EntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 372);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelCentral);
            this.MaximizeBox = false;
            this.Name = "EntradaProductos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Registro de Movimientos de Productos";
            this.Load += new System.EventHandler(this.EntradaProductos_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private MetroFramework.Controls.MetroDateTime date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtPrecioC;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPrecioV;
        private MetroFramework.Controls.MetroTextBox txtRecibirRetirar;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnAvanzar;
        private MetroFramework.Controls.MetroGrid dataGridView;
        private MetroFramework.Controls.MetroTextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroRadioButton rbSalida;
        private MetroFramework.Controls.MetroRadioButton rbEntrada;
    }
}