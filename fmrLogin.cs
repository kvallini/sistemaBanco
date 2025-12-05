using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibreria2025;

namespace sistemaBanco
{
    public partial class frmLogin : Form
    {
        //Variables Globales
        public DataSet ds;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void limpiar()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtUsuario.Focus();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasena;

                contrasena = Utilidades.codificar(txtClave.Text);
                string cmd = string.Format("select * from USUARIOS where CODUSUARIOS='{0}' and clave='{1}'", txtUsuario.Text.Trim(), contrasena);

                DataSet ds = Utilidades.ejecutar(cmd);

                string usario = ds.Tables[0].Rows[0]["CODUSUARIOS"].ToString();
                string clave = ds.Tables[0].Rows[0]["CONTRASENA"].ToString();
                string perfil = ds.Tables[0].Rows[0]["NOPERFIL"].ToString();

                if (usario == txtUsuario.Text.Trim() && clave == Utilidades.codificar(txtClave.Text.Trim()))
                {
                    if (perfil == "1")
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else if (perfil == "2")
                    {
                        frmMenu menu = new frmMenu();
                        menu.reportesToolStripMenuItem.Visible = false;
                        menu.mantenimientoToolStripMenuItem.Visible = false;
                        menu.Show();
                        this.Hide();
                    }
                    else if (perfil == "3")
                    {
                        frmMenu menu = new frmMenu();
                        menu.reportesToolStripMenuItem.Visible = false;
                        menu.mantenimientoToolStripMenuItem.Visible = false;
                        menu.catalogoDeSucursalesToolStripMenuItem.Visible = false;
                        menu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Incorrecta. Favor verifique..", "Ingreso a Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }


            }
            catch (Exception ex)
            { 
                ex.ToString();
                MessageBox.Show("Usuario o contraseña Incorrecta. Favor verifique..", "Ingreso a Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }
            
        }
    }
}
