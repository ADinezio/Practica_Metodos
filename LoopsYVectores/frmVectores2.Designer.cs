namespace LoopsYVectores
{
    partial class frmVectores2
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
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.btnMostrarTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.Location = new System.Drawing.Point(283, 67);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(122, 23);
            this.btnCargaDatos.TabIndex = 0;
            this.btnCargaDatos.Text = "Cargar Datos";
            this.btnCargaDatos.UseVisualStyleBackColor = true;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // btnMostrarTotal
            // 
            this.btnMostrarTotal.Location = new System.Drawing.Point(473, 66);
            this.btnMostrarTotal.Name = "btnMostrarTotal";
            this.btnMostrarTotal.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTotal.TabIndex = 1;
            this.btnMostrarTotal.Text = "Mostrar Total";
            this.btnMostrarTotal.UseVisualStyleBackColor = true;
            this.btnMostrarTotal.Click += new System.EventHandler(this.btnMostrarTotal_Click);
            // 
            // frmVectores2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarTotal);
            this.Controls.Add(this.btnCargaDatos);
            this.Name = "frmVectores2";
            this.Text = "frmVectores2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaDatos;
        private System.Windows.Forms.Button btnMostrarTotal;
    }
}