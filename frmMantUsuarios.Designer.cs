namespace sistemaBanco
{
    partial class frmMantUsuarios
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblApellidoI = new System.Windows.Forms.Label();
            this.lblApellidoII = new System.Windows.Forms.Label();
            this.lblConfirmarCOntrasena = new System.Windows.Forms.Label();
            this.lblInhabilitar = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoI = new System.Windows.Forms.TextBox();
            this.txtApellidoII = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(52, 44);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(52, 98);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 15);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(52, 153);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(52, 213);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(80, 15);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(387, 98);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(41, 15);
            this.lblPerfil.TabIndex = 4;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblApellidoI
            // 
            this.lblApellidoI.AutoSize = true;
            this.lblApellidoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoI.Location = new System.Drawing.Point(387, 153);
            this.lblApellidoI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoI.Name = "lblApellidoI";
            this.lblApellidoI.Size = new System.Drawing.Size(67, 15);
            this.lblApellidoI.TabIndex = 5;
            this.lblApellidoI.Text = "Apellido1";
            // 
            // lblApellidoII
            // 
            this.lblApellidoII.AutoSize = true;
            this.lblApellidoII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoII.Location = new System.Drawing.Point(687, 153);
            this.lblApellidoII.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoII.Name = "lblApellidoII";
            this.lblApellidoII.Size = new System.Drawing.Size(67, 15);
            this.lblApellidoII.TabIndex = 6;
            this.lblApellidoII.Text = "Apellido2";
            // 
            // lblConfirmarCOntrasena
            // 
            this.lblConfirmarCOntrasena.AutoSize = true;
            this.lblConfirmarCOntrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarCOntrasena.Location = new System.Drawing.Point(387, 213);
            this.lblConfirmarCOntrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarCOntrasena.Name = "lblConfirmarCOntrasena";
            this.lblConfirmarCOntrasena.Size = new System.Drawing.Size(147, 15);
            this.lblConfirmarCOntrasena.TabIndex = 7;
            this.lblConfirmarCOntrasena.Text = "Confirmar Contraseña";
            // 
            // lblInhabilitar
            // 
            this.lblInhabilitar.AutoSize = true;
            this.lblInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInhabilitar.Location = new System.Drawing.Point(407, 44);
            this.lblInhabilitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInhabilitar.Name = "lblInhabilitar";
            this.lblInhabilitar.Size = new System.Drawing.Size(126, 15);
            this.lblInhabilitar.TabIndex = 8;
            this.lblInhabilitar.Text = "Inhabilitar Usuario";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(836, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(55, 287);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(1171, 259);
            this.dgvDatos.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 3;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(93, 650);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(151, 52);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderSize = 3;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(320, 650);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(151, 52);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(547, 650);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 52);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(773, 650);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 52);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1000, 650);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 52);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(836, 78);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(267, 35);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(159, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 21);
            this.txtUsuario.TabIndex = 17;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(159, 98);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(132, 21);
            this.txtCedula.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 21);
            this.txtNombre.TabIndex = 19;
            // 
            // txtApellidoI
            // 
            this.txtApellidoI.Location = new System.Drawing.Point(539, 150);
            this.txtApellidoI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoI.Name = "txtApellidoI";
            this.txtApellidoI.Size = new System.Drawing.Size(132, 21);
            this.txtApellidoI.TabIndex = 20;
            // 
            // txtApellidoII
            // 
            this.txtApellidoII.Location = new System.Drawing.Point(773, 150);
            this.txtApellidoII.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoII.Name = "txtApellidoII";
            this.txtApellidoII.Size = new System.Drawing.Size(132, 21);
            this.txtApellidoII.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(159, 210);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 21);
            this.textBox6.TabIndex = 22;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(539, 210);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(132, 21);
            this.txtConfirmar.TabIndex = 23;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(539, 97);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(121, 23);
            this.cmbPerfil.TabIndex = 24;
            // 
            // frmMantUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 741);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtApellidoII);
            this.Controls.Add(this.txtApellidoI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblInhabilitar);
            this.Controls.Add(this.lblConfirmarCOntrasena);
            this.Controls.Add(this.lblApellidoII);
            this.Controls.Add(this.lblApellidoI);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMantUsuarios";
            this.Text = "frmMantUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblApellidoI;
        private System.Windows.Forms.Label lblApellidoII;
        private System.Windows.Forms.Label lblConfirmarCOntrasena;
        private System.Windows.Forms.Label lblInhabilitar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoI;
        private System.Windows.Forms.TextBox txtApellidoII;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.ComboBox cmbPerfil;
    }
}