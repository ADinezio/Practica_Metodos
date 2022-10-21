namespace LoopsYVectores
{
    partial class frmVectores6
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
            this.btnProvincias = new System.Windows.Forms.Button();
            this.btnTemperaturas = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lstImprimeDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnProvincias
            // 
            this.btnProvincias.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProvincias.Location = new System.Drawing.Point(301, 64);
            this.btnProvincias.Name = "btnProvincias";
            this.btnProvincias.Size = new System.Drawing.Size(240, 23);
            this.btnProvincias.TabIndex = 0;
            this.btnProvincias.Text = "Ingresar Provincia";
            this.btnProvincias.UseVisualStyleBackColor = false;
            this.btnProvincias.Click += new System.EventHandler(this.btnProvincias_Click);
            // 
            // btnTemperaturas
            // 
            this.btnTemperaturas.Location = new System.Drawing.Point(301, 107);
            this.btnTemperaturas.Name = "btnTemperaturas";
            this.btnTemperaturas.Size = new System.Drawing.Size(240, 23);
            this.btnTemperaturas.TabIndex = 1;
            this.btnTemperaturas.Text = "Ingresar Temperaturas";
            this.btnTemperaturas.UseVisualStyleBackColor = true;
            this.btnTemperaturas.Click += new System.EventHandler(this.btnTemperaturas_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(301, 160);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(240, 23);
            this.btnMostrarDatos.TabIndex = 2;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lstImprimeDatos
            // 
            this.lstImprimeDatos.FormattingEnabled = true;
            this.lstImprimeDatos.Location = new System.Drawing.Point(301, 216);
            this.lstImprimeDatos.Name = "lstImprimeDatos";
            this.lstImprimeDatos.Size = new System.Drawing.Size(240, 134);
            this.lstImprimeDatos.TabIndex = 3;
            // 
            // frmVectores6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstImprimeDatos);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnTemperaturas);
            this.Controls.Add(this.btnProvincias);
            this.Name = "frmVectores6";
            this.Text = "frmVectores6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProvincias;
        private System.Windows.Forms.Button btnTemperaturas;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.ListBox lstImprimeDatos;
    }
}