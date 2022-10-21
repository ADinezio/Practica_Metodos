namespace LoopsYVectores
{
    partial class frmVectores3
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
            this.btnNombres = new System.Windows.Forms.Button();
            this.btnSalarios = new System.Windows.Forms.Button();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(299, 72);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(189, 23);
            this.btnNombres.TabIndex = 0;
            this.btnNombres.Text = "Ingresar Nombres Operarios";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // btnSalarios
            // 
            this.btnSalarios.Location = new System.Drawing.Point(299, 121);
            this.btnSalarios.Name = "btnSalarios";
            this.btnSalarios.Size = new System.Drawing.Size(189, 23);
            this.btnSalarios.TabIndex = 1;
            this.btnSalarios.Text = "Ingresar Salarios";
            this.btnSalarios.UseVisualStyleBackColor = true;
            this.btnSalarios.Click += new System.EventHandler(this.btnSalarios_Click);
            // 
            // btnMostrarInfo
            // 
            this.btnMostrarInfo.Location = new System.Drawing.Point(299, 177);
            this.btnMostrarInfo.Name = "btnMostrarInfo";
            this.btnMostrarInfo.Size = new System.Drawing.Size(189, 23);
            this.btnMostrarInfo.TabIndex = 2;
            this.btnMostrarInfo.Text = "Mostrar Info";
            this.btnMostrarInfo.UseVisualStyleBackColor = true;
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);
            // 
            // frmVectores3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarInfo);
            this.Controls.Add(this.btnSalarios);
            this.Controls.Add(this.btnNombres);
            this.Name = "frmVectores3";
            this.Text = "frmVectores3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Button btnSalarios;
        private System.Windows.Forms.Button btnMostrarInfo;
    }
}