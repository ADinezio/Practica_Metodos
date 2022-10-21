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

namespace LoopsYVectores
{
    public partial class frmVectores6 : Form
    {
        string[] provincias;
        double[] temperaturas1;
        double[] temperaturas2;
        double[] temperaturas3;
        double[] temperaturas4;

        public frmVectores6()
        {
            InitializeComponent();
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            provincias = new string[4];
            CargaProvincias(provincias);
        }

        private void btnTemperaturas_Click(object sender, EventArgs e)
        {
            temperaturas1 = new double[3];
            temperaturas2 = new double[3];
            temperaturas3 = new double[3];
            temperaturas4 = new double[3];  
            CargaTemperaturas(temperaturas1);
            CargaTemperaturas(temperaturas2);
            CargaTemperaturas(temperaturas3);   
            CargaTemperaturas(temperaturas4);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MuestraProvincias(provincias);
            MuestraTemperaturas(temperaturas1);
            MuestraTemperaturas(temperaturas2);
            MuestraTemperaturas(temperaturas3);
            MuestraTemperaturas(temperaturas4);
        }

        private void CargaProvincias(string[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i] = Interaction.InputBox($"{i + 1}. Ingrese nombre de provincia : ");
            }
        }
        private void CargaTemperaturas(double[] temperaturas)
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                temperaturas[i] =Convert.ToDouble(Interaction.InputBox($"Mes {i + 1}. Ingrese temperatura : "));
            }
        }

        private void MuestraProvincias(string[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                lstImprimeDatos.Items.Add($"{i+1}. {provincias[i]}");
            }
        }
        private void MuestraTemperaturas(double[] temperaturas)
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                lstImprimeDatos.Items.Add($"{i + 1}. {temperaturas[i]}");
            }
            lstImprimeDatos.Items.Add("\n");
        }
    }
}
