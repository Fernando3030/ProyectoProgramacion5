﻿namespace ProyectoProgV
{
    partial class ReporteProveedores
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
            this.panelCentral = new MetroFramework.Controls.MetroPanel();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnGenerar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.panelOpciones = new MetroFramework.Controls.MetroPanel();
            this.rbTodos = new MetroFramework.Controls.MetroRadioButton();
            this.rbFecha = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelCentral.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral.Controls.Add(this.dateHasta);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.dateDesde);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.HorizontalScrollbarBarColor = true;
            this.panelCentral.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCentral.HorizontalScrollbarSize = 10;
            this.panelCentral.Location = new System.Drawing.Point(23, 148);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(324, 95);
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
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(170, 43);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(132, 29);
            this.dateHasta.Style = MetroFramework.MetroColorStyle.Brown;
            this.dateHasta.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hasta:";
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(17, 43);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(132, 29);
            this.dateDesde.Style = MetroFramework.MetroColorStyle.Brown;
            this.dateDesde.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Desde:";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnGenerar
            // 
            this.btnGenerar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGenerar.Highlight = true;
            this.btnGenerar.Location = new System.Drawing.Point(13, 7);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 35);
            this.btnGenerar.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar";
            this.metroToolTip1.SetToolTip(this.btnGenerar, "Nuevo Proveedor");
            this.btnGenerar.UseCustomBackColor = true;
            this.btnGenerar.UseCustomForeColor = true;
            this.btnGenerar.UseSelectable = true;
            this.btnGenerar.UseStyleColors = true;
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
            this.panelOpciones.Controls.Add(this.btnGenerar);
            this.panelOpciones.HorizontalScrollbarBarColor = true;
            this.panelOpciones.HorizontalScrollbarHighlightOnWheel = false;
            this.panelOpciones.HorizontalScrollbarSize = 10;
            this.panelOpciones.Location = new System.Drawing.Point(91, 251);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(191, 56);
            this.panelOpciones.TabIndex = 21;
            this.panelOpciones.VerticalScrollbarBarColor = true;
            this.panelOpciones.VerticalScrollbarHighlightOnWheel = false;
            this.panelOpciones.VerticalScrollbarSize = 10;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbTodos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbTodos.Location = new System.Drawing.Point(18, 25);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(62, 19);
            this.rbTodos.Style = MetroFramework.MetroColorStyle.Brown;
            this.rbTodos.TabIndex = 22;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseSelectable = true;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbFecha.Location = new System.Drawing.Point(103, 25);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(88, 19);
            this.rbFecha.Style = MetroFramework.MetroColorStyle.Brown;
            this.rbFecha.TabIndex = 23;
            this.rbFecha.Text = "Por Fecha:";
            this.rbFecha.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 59);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // ReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelCentral);
            this.MaximizeBox = false;
            this.Name = "ReporteProveedores";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Reporte Proveedores";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelCentral;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btnGenerar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroPanel panelOpciones;
        private MetroFramework.Controls.MetroDateTime dateDesde;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroRadioButton rbTodos;
        private MetroFramework.Controls.MetroRadioButton rbFecha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}