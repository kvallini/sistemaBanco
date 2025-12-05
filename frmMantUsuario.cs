using myLibreria2025;
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
    public partial class frmMantUsuario : Form
    {
        private object ds;

        public frmMantUsuario()
        {
            InitializeComponent();
        }

        private void frmMantUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = "select DESCPERFIL from PERFILES";

                ds = Utilidades.ejecutar(cmd);
                cmbPerfil.DataSource = ds.Tables[0.DefaultView];
                cmbPerfil.ValueMember = "DESCPERFIL";
                cmbPerfil.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: 001 " + ex.Message, "Sistema Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPerfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("select NOPERFIL from PERFILES where DESCPERFIL = '{0}'", cmbPerfil.Text);
                ds = Utilidades.ejecutar(cmd);
                numPerfil = ds.Tables[0].Rows[0]["NOPERFIL"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: 002 " + ex.Message, "Sistema Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            grabar();
        }
        public void grabar()
        {
            try
            {
                string fecha;
                string contrasena;
                int estado = 1;

                fecha = DateTime.Now.ToString("dd-MM-yyyy");

                contrasena = Utilidades.codificar(txtContrasena.Text);

                if (txtContrasena.Text == txtConfirmar.Text)
                {
                    string cmd = string.Format("insert into USUARIOS (CODUSUARIO, CEDULA, NOMBRE, APELLIDO1, APELLIDO2, CONTRASENA " +
                        "NOPERFIL, FEC_CREACION, FEC_MODIFICACION, NOESTADO) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}')",
                    txtUsuario.Text.Trim(), txtCedula.Text, txtNombre.Text.Trim(), txtApellidoI.Text.Trim(), txtApellidoII.Text.Trim(), contrasena, numPerfil, fecha, fecha, estado);
                    Utilidades.ejecutar(cmd);
                }
                else
                {
                    MessageBox.Show("Las Contraseñas no coinciden", "Sistema Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                MessageBox.Show("Se crea Usuario" + txtUsuario.Text + "Satisfactoriamente", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: 003 " + ex.Message, "Sistema Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargar();

        }
        public void cargar()
        {
            try
            {
                string cmd = string.Format("select a.CODUSUARIO USUARIO. a.CEDULA, a.NOMBRE, aAPELLIDO1, aAPELLIDO2," +
                    "b.DESCPERFIL PERFIL. a.FEC_CREACION, a.FEC_MODIFICACION, cDESCESTADO ESTADO " +
                    "from USUARIOS a, PERFILES b, ESTADO c " +
                    "WHERE CODUSUARIO = '{0}' and a.NOPERFIL = b.NOPERFIL and a.NOESTADO = c.NOESTADO", txtUsuario.Text);
                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0];
                txtCedula.Text = ds.Tables[0].Rows[0]["CEDULA"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString();
                txtApellidoI.Text = ds.Tables[0].Rows[0]["APELLIDO1"].ToString();
                txtApellidoII.Text = ds.Tables[0].Rows[0]["APELLIDO2"].ToString();
                txtContrasena.Text = Utilidades.decodificar(ds.Tables[0].Rows[0]["CONTRASENA"].ToString());
                txtConfirmar.Text = Utilidades.decodificar(ds.Tables[0].Rows[0]["CONTRASENA"].ToString());
                cmbPerfil.Text = ds.Tables[0].Rows[0]["NOPERFIL"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error: 004 " + ex.Message, "Sistema Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void ckbEstado_CheckedChanged(object sender, EventArgs e)
        {
            string cmd;
            int valor;

            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Debe agregar un Usuario para la Habilitacion / inhabilitacion", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();


            }
            else
            {
                if (ckbEstado.Checked == true)
                {
                    valor = 0;
                    cmd = string.Format("update USUARIOS set NOESTADO = '{0}' where CODUSUARIO = '{1}'", valor, txtUsuario.Text);
                    Utilidades.ejecutar(cmd);
                    MessageBox.Show("El Usuario ha sido Inhabilitado", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }

                else
                {
                    valor = 1;
                    cmd = string.Format("update USUARIOS set NOESTADO = '{0}' where CODUSUARIO = '{1}'", valor, txtUsuario.Text);
                    Utilidades.ejecutar(cmd);
                    MessageBox.Show("El Usuario ha sido Habilitado satisfactoriamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }

            }
        }

    }
}