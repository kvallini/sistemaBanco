using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaBanco
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();//oculta el menu
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catalogoDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursales sucursales = new frmSucursales();
            sucursales.MdiParent = this;
            sucursales.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUsuarios usuarios = new frmMantUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }
    }
}
