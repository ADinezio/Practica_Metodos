namespace Practica_Metodos
{
    partial class frmCaso4
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
            this.lblFigura = new System.Windows.Forms.Label();
            this.txtFigura = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(147, 70);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(209, 13);
            this.lblFigura.TabIndex = 0;
            this.lblFigura.Text = "Ingrese de que figura quiere saber el area :";
            // 
            // txtFigura
            // 
            this.txtFigura.Location = new System.Drawing.Point(385, 70);
            this.txtFigura.Name = "txtFigura";
            this.txtFigura.Size = new System.Drawing.Size(100, 20);
            this.txtFigura.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(385, 127);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtFigura);
            this.Controls.Add(this.lblFigura);
            this.Name = "frmCaso4";
            this.Text = "frmCaso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.TextBox txtFigura;
        private System.Windows.Forms.Button btnEnviar;
    }
}