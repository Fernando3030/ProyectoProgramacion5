namespace ProyectoProgV
{
    partial class VentanaPrincipal
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mercaderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMercaderiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mercaderiaToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(20, 60);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(793, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.SaddleBrown;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProveedores});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = global::ProyectoProgV.Properties.Resources.group_add_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 25);
            this.toolStripMenuItem1.Text = "Registros";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.BackColor = System.Drawing.Color.Chocolate;
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.Image = global::ProyectoProgV.Properties.Resources.User_Administrator_Blue_icon;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(167, 26);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.BackColor = System.Drawing.Color.Chocolate;
            this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.Image = global::ProyectoProgV.Properties.Resources.User_Files_icon;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(167, 26);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // mercaderiaToolStripMenuItem
            // 
            this.mercaderiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMercaderiaToolStripMenuItem,
            this.registrarProductoToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.mercaderiaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercaderiaToolStripMenuItem.Name = "mercaderiaToolStripMenuItem";
            this.mercaderiaToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.mercaderiaToolStripMenuItem.Text = "Mercaderia";
            // 
            // registrarMercaderiaToolStripMenuItem
            // 
            this.registrarMercaderiaToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registrarMercaderiaToolStripMenuItem.Name = "registrarMercaderiaToolStripMenuItem";
            this.registrarMercaderiaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarMercaderiaToolStripMenuItem.Text = "Registrar Mercaderia";
            this.registrarMercaderiaToolStripMenuItem.Click += new System.EventHandler(this.registrarMercaderiaToolStripMenuItem_Click);
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Categoría";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeProductosToolStripMenuItem,
            this.salidaDeProductosToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // entradaDeProductosToolStripMenuItem
            // 
            this.entradaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.entradaDeProductosToolStripMenuItem.Name = "entradaDeProductosToolStripMenuItem";
            this.entradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.entradaDeProductosToolStripMenuItem.Text = "Entrada de Productos";
            this.entradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosToolStripMenuItem_Click);
            // 
            // salidaDeProductosToolStripMenuItem
            // 
            this.salidaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.salidaDeProductosToolStripMenuItem.Name = "salidaDeProductosToolStripMenuItem";
            this.salidaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.salidaDeProductosToolStripMenuItem.Text = "Salida de Productos";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaProveedorToolStripMenuItem,
            this.facturaClienteToolStripMenuItem});
            this.facturasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // facturaProveedorToolStripMenuItem
            // 
            this.facturaProveedorToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.facturaProveedorToolStripMenuItem.Name = "facturaProveedorToolStripMenuItem";
            this.facturaProveedorToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.facturaProveedorToolStripMenuItem.Text = "Factura Proveedor";
            this.facturaProveedorToolStripMenuItem.Click += new System.EventHandler(this.facturaProveedorToolStripMenuItem_Click);
            // 
            // facturaClienteToolStripMenuItem
            // 
            this.facturaClienteToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.facturaClienteToolStripMenuItem.Name = "facturaClienteToolStripMenuItem";
            this.facturaClienteToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.facturaClienteToolStripMenuItem.Text = "Factura Cliente";
            this.facturaClienteToolStripMenuItem.Click += new System.EventHandler(this.facturaClienteToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.facturasClienteToolStripMenuItem,
            this.facturasProveedorToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // facturasClienteToolStripMenuItem
            // 
            this.facturasClienteToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.facturasClienteToolStripMenuItem.Name = "facturasClienteToolStripMenuItem";
            this.facturasClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.facturasClienteToolStripMenuItem.Text = "Facturas Cliente";
            // 
            // facturasProveedorToolStripMenuItem
            // 
            this.facturasProveedorToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.facturasProveedorToolStripMenuItem.Name = "facturasProveedorToolStripMenuItem";
            this.facturasProveedorToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.facturasProveedorToolStripMenuItem.Text = "Facturas Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Fernando Castillo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.SaddleBrown;
            this.metroButton1.BackgroundImage = global::ProyectoProgV.Properties.Resources.exit2;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(752, 53);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(33, 32);
            this.metroButton1.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.metroButton1, " Cerrar Sesion");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::ProyectoProgV.Properties.Resources.nutril_crop_u3908;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(107, 141);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(622, 214);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(833, 413);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "VentanaPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Ventana Principal";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem mercaderiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMercaderiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasProveedorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaDeProductosToolStripMenuItem;
    }
}