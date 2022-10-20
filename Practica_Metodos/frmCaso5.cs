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
            string sexo = txtSexo.Text;
            string tipo = txtTipo.Text;

            sexo = ValidaSexo(sexo);

           
        }

        public void ValidaTipo(string tipoUsuario)
        {
            string tipo = tipoUsuario.ToUpper();
            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                    MessageBox.Show("Sos Administrador!");
                    break;

                case "ESTANDAR":
                    MessageBox.Show("Sos usuario Estandar!");
                    break;

                case "INVITADO":
                    MessageBox.Show("Sos usuario Invitado!");
                    break;
                default: MessageBox.Show("Usuario no valido!");
                    break;
            }
        }
        public string ValidaSexo(string sexo)
        {
            string sex = sexo.ToUpper();
            while (sex != "FEMENINO" || sex != "MASCULINO")
            {
                MessageBox.Show("Error");
                sex=Interaction.InputBox("Ingresa tu sexo :").ToUpper();
            }
            return sex.ToLower();
        }
        public void ImprimeMSJ(string tipoUsuario, string sexo, string nombre)
        {
            MessageBox.Show($"Usuario: {nombre}\nSexo: {sexo}\nRol: {tipoUsuario}");
        }
    }
}
