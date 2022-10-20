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
    public partial class frmCaso6 : Form
    {
        public frmCaso6()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string apellido = txtApellido.Text;
            int edad = DateTime.Now.Year - dtEdad.Value.Date.Year;
            
            if(dtEdad.Value.Date == DateTime.Now.Date)
            {
                ImprimeNombreCompleto(nombre, apellido);
            }
            else
            {
                ImprimeNombreCompletoYEdad(nombre, apellido, edad);
            }
            
        }

        private void ImprimeNombreCompleto(string nombre,string apellido)
        {
            MessageBox.Show($"Nombre : {nombre}\nApellido :{apellido}");
        }
        private void ImprimeNombreCompletoYEdad(string nombre, string apellido,int edad)
        {
            MessageBox.Show($"Nombre : {nombre}\nApellido : {apellido}\nEdad: {edad}");
        }
    }
}
