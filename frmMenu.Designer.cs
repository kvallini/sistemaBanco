using System;

namespace sistemaBanco
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsOpciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsOpciones
            // 
            this.mnsOpciones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.mnsOpciones.Location = new System.Drawing.Point(0, 0);
            this.mnsOpciones.Name = "mnsOpciones";
            this.mnsOpciones.Size = new System.Drawing.Size(800, 25);
            this.mnsOpciones.TabIndex = 0;
            this.mnsOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoDeClientesToolStripMenuItem,
            this.catalogoDeSucursalesToolStripMenuItem,
            this.usuariosDelSistemaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeClientesToolStripMenuItem,
            this.informeDeSucursalesToolStripMenuItem,
            this.informeDeUsuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.reportesToolStripMenuItem.Text = "Reportes ";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catalogoDeClientesToolStripMenuItem
            // 
            this.catalogoDeClientesToolStripMenuItem.Name = "catalogoDeClientesToolStripMenuItem";
            this.catalogoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.catalogoDeClientesToolStripMenuItem.Text = "Catalogo de Clientes";
            // 
            // catalogoDeSucursalesToolStripMenuItem
            // 
            this.catalogoDeSucursalesToolStripMenuItem.Name = "catalogoDeSucursalesToolStripMenuItem";
            this.catalogoDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.catalogoDeSucursalesToolStripMenuItem.Text = "Catalogo de Sucursales";
            this.catalogoDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeSucursalesToolStripMenuItem_Click);
            // 
            // usuariosDelSistemaToolStripMenuItem
            // 
            this.usuariosDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.cambioContrasenaToolStripMenuItem});
            this.usuariosDelSistemaToolStripMenuItem.Name = "usuariosDelSistemaToolStripMenuItem";
            this.usuariosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.usuariosDelSistemaToolStripMenuItem.Text = "Usuarios del Sistema";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // cambioContrasenaToolStripMenuItem
            // 
            this.cambioContrasenaToolStripMenuItem.Name = "cambioContrasenaToolStripMenuItem";
            this.cambioContrasenaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cambioContrasenaToolStripMenuItem.Text = "Cambio Contrasena";
            // 
            // informeDeClientesToolStripMenuItem
            // 
            this.informeDeClientesToolStripMenuItem.Name = "informeDeClientesToolStripMenuItem";
            this.informeDeClientesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.informeDeClientesToolStripMenuItem.Text = "Informe de Clientes";
            // 
            // informeDeSucursalesToolStripMenuItem
            // 
            this.informeDeSucursalesToolStripMenuItem.Name = "informeDeSucursalesToolStripMenuItem";
            this.informeDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.informeDeSucursalesToolStripMenuItem.Text = "Informe de Sucursales";
            // 
            // informeDeUsuariosToolStripMenuItem
            // 
            this.informeDeUsuariosToolStripMenuItem.Name = "informeDeUsuariosToolStripMenuItem";
            this.informeDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.informeDeUsuariosToolStripMenuItem.Text = "Informe de Usuarios";
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientoToolStripMenuItem.Text = "Movimientos";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mnsOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsOpciones;
            this.Name = "frmMenu";
            this.Text = "Sistema de Banco BCR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsOpciones.ResumeLayout(false);
            this.mnsOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsOpciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContrasenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
    }
}

