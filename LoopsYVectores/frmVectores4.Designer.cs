namespace LoopsYVectores
{
    partial class frmVectores4
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
            this.btnCargaPersonas = new System.Windows.Forms.Button();
            this.btnCargaEdades = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstMayoresEdad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargaPersonas
            // 
            this.btnCargaPersonas.Location = new System.Drawing.Point(348, 63);
            this.btnCargaPersonas.Name = "btnCargaPersonas";
            this.btnCargaPersonas.Size = new System.Drawing.Size(196, 23);
            this.btnCargaPersonas.TabIndex = 0;
            this.btnCargaPersonas.Text = "Cargar Personas";
            this.btnCargaPersonas.UseVisualStyleBackColor = true;
            this.btnCargaPersonas.Click += new System.EventHandler(this.btnCargaPersonas_Click);
            // 
            // btnCargaEdades
            // 
            this.btnCargaEdades.Location = new System.Drawing.Point(348, 108);
            this.btnCargaEdades.Name = "btnCargaEdades";
            this.btnCargaEdades.Size = new System.Drawing.Size(196, 23);
            this.btnCargaEdades.TabIndex = 1;
            this.btnCargaEdades.Text = "Cargar Edades ";
            this.btnCargaEdades.UseVisualStyleBackColor = true;
            this.btnCargaEdades.Click += new System.EventHandler(this.btnCargaEdades_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(348, 166);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(196, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstMayoresEdad
            // 
            this.lstMayoresEdad.FormattingEnabled = true;
            this.lstMayoresEdad.Location = new System.Drawing.Point(348, 224);
            this.lstMayoresEdad.Name = "lstMayoresEdad";
            this.lstMayoresEdad.Size = new System.Drawing.Size(196, 121);
            this.lstMayoresEdad.TabIndex = 3;
            // 
            // frmVectores4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMayoresEdad);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargaEdades);
            this.Controls.Add(this.btnCargaPersonas);
            this.Name = "frmVectores4";
            this.Text = "frmVectores4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaPersonas;
        private System.Windows.Forms.Button btnCargaEdades;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstMayoresEdad;
    }
}