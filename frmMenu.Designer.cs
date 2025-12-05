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
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioContrasenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsOpciones
            // 
            this.mnsOpciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.mnsOpciones.Location = new System.Drawing.Point(0, 0);
            this.mnsOpciones.Name = "mnsOpciones";
            this.mnsOpciones.Size = new System.Drawing.Size(800, 27);
            this.mnsOpciones.TabIndex = 0;
            this.mnsOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoDeClientesToolStripMenuItem,
            this.catalogoDeSucursalesToolStripMenuItem,
            this.usuariosDelSistemaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // catalogoDeClientesToolStripMenuItem
            // 
            this.catalogoDeClientesToolStripMenuItem.Name = "catalogoDeClientesToolStripMenuItem";
            this.catalogoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.catalogoDeClientesToolStripMenuItem.Text = "Catalogo de Clientes";
            // 
            // catalogoDeSucursalesToolStripMenuItem
            // 
            this.catalogoDeSucursalesToolStripMenuItem.Name = "catalogoDeSucursalesToolStripMenuItem";
            this.catalogoDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.catalogoDeSucursalesToolStripMenuItem.Text = "Catalogo de Sucursales";
            this.catalogoDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.catalogoDeSucursalesToolStripMenuItem_Click);
            // 
            // usuariosDelSistemaToolStripMenuItem
            // 
            this.usuariosDelSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.cambioContrasenaToolStripMenuItem});
            this.usuariosDelSistemaToolStripMenuItem.Name = "usuariosDelSistemaToolStripMenuItem";
            this.usuariosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.usuariosDelSistemaToolStripMenuItem.Text = "Usuarios del Sistema";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.agregarToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // cambioContrasenaToolStripMenuItem
            // 
            this.cambioContrasenaToolStripMenuItem.Name = "cambioContrasenaToolStripMenuItem";
            this.cambioContrasenaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.cambioContrasenaToolStripMenuItem.Text = "Cambio Contraseña";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeClientesToolStripMenuItem,
            this.informeDeSucursalesToolStripMenuItem,
            this.informeDeUsuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.reportesToolStripMenuItem.Text = "Reportes ";
            // 
            // informeDeClientesToolStripMenuItem
            // 
            this.informeDeClientesToolStripMenuItem.Name = "informeDeClientesToolStripMenuItem";
            this.informeDeClientesToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.informeDeClientesToolStripMenuItem.Text = "Informe de Clientes";
            // 
            // informeDeSucursalesToolStripMenuItem
            // 
            this.informeDeSucursalesToolStripMenuItem.Name = "informeDeSucursalesToolStripMenuItem";
            this.informeDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.informeDeSucursalesToolStripMenuItem.Text = "Informe de Sucursales";
            // 
            // informeDeUsuariosToolStripMenuItem
            // 
            this.informeDeUsuariosToolStripMenuItem.Name = "informeDeUsuariosToolStripMenuItem";
            this.informeDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.informeDeUsuariosToolStripMenuItem.Text = "Informe de Usuarios";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientoToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.movimientoToolStripMenuItem.Text = "Movimientos Cuentas";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
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
            this.Text = "Sistema de Banco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsOpciones.ResumeLayout(false);
            this.mnsOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioContrasenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mnsOpciones;
        public System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem catalogoDeSucursalesToolStripMenuItem;
    }
}

