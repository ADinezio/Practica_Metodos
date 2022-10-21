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

namespace LoopsYVectores
{
    public partial class frmVectores2 : Form
    {
        double[] precios;
        public frmVectores2()
        {
            InitializeComponent();
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            precios= new double[8];
            CargarDatos(precios);
            

        }
        private void btnMostrarTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El total es : {SumaPrecios(precios).ToString()}");
        }

        private void CargarDatos(double[] precios)
        {
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i] = Convert.ToDouble(Interaction.InputBox("Ingresa Precio : "));
            }            
        }

        private double SumaPrecios(double[] precios)
        {
            double suma = 0;
            for (int i = 0; i < precios.Length; i++)
            {
                suma += precios[i];
            }
            return suma;
        }

        
    }
}
