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
            tipo=ValidaTipo(tipo);
            ImprimeMSJ(tipo,sexo,nombre);   
        }

        public string ValidaTipo(string tipoUsuario)
        {
            string tipo = tipoUsuario.ToLower();
            while (tipo == "administrador" || tipo == "invitado" || tipo =="estandar")
            {
                tipo = Interaction.InputBox("Error\nIngresa tu tipo de usuario :","Tipo");
                tipo=tipo.ToLower();
            }
            return tipo;
        }
        public string ValidaSexo(string sexo)
        {
            string sex = sexo.ToLower();
            while (sex != "femenino" || sex != "masculino")
            {
                sex = Interaction.InputBox("Error\nIngresa tu sexo :", "Sexo").ToLower();
            }
            return sex;
        }
        public void ImprimeMSJ(string tipoUsuario, string sexo, string nombre)
        {
            MessageBox.Show($"Usuario: {nombre}\nSexo: {sexo}\nRol: {tipoUsuario}");
        }
    }
}
