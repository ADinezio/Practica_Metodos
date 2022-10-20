using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace Practica_Metodos
{
    public partial class frmCaso5 : Form
    {
        public frmCaso5()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string sexo = txtSexo.Text.ToUpper();
            string tipo = txtTipo.Text.ToUpper();

            if (!ValidaTipo(tipo))
            {
                MessageBox.Show("-ERROR,tipo invalido");
            }
            else if (!ValidaSexo(sexo))
            {
                MessageBox.Show("-ERROR,sexo invalido");
            }
            else
            {
                ImprimeMSJ(tipo,sexo,nombre);
            }

        }

        public bool ValidaTipo(string tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                case "ESTANDAR":
                case "INVITADOS":
                    return true;
                default:
                    return false;
            }
        }
        public bool ValidaSexo(string sexo)
        {
            switch (sexo)
            {
                case "MASCULINO":
                case "FEMENINO":
                    return true;
                default:
                    return false;
            }
        }
        public void ImprimeMSJ(string tipoUsuario, string sexo, string nombre)
        {
            MessageBox.Show($"Usuario: {nombre}\nSexo: {sexo}\nRol: {tipoUsuario}");
        }
    }
}
