namespace sistemaBanco
{
    partial class frmManualUsuario
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
            this.btnManualUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManualUsuario
            // 
            this.btnManualUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManualUsuario.Location = new System.Drawing.Point(215, 149);
            this.btnManualUsuario.Name = "btnManualUsuario";
            this.btnManualUsuario.Size = new System.Drawing.Size(137, 84);
            this.btnManualUsuario.TabIndex = 0;
            this.btnManualUsuario.Text = "Manual de Usuario";
            this.btnManualUsuario.UseVisualStyleBackColor = true;
            this.btnManualUsuario.Click += new System.EventHandler(this.btnManualUsuario_Click);
            // 
            // frmManualUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 375);
            this.Controls.Add(this.btnManualUsuario);
            this.Name = "frmManualUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManualUsuario;
    }
}