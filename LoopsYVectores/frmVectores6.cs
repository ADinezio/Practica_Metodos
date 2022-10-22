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
using System.Windows.Forms.VisualStyles;
using static LoopsYVectores.frmVectores6;

namespace LoopsYVectores
{
    public partial class frmVectores6 : Form
    {
        public struct Provincia
        {
            public string NombreProvincia;
            public int[] Temperaturas;
            public int PromedioTemperatura;
        }
        Provincia[] provincias;

        public frmVectores6()
        {
            InitializeComponent();
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            provincias = new Provincia[4];
            InicializaProvincias(provincias);
            CargaProvincias(provincias);

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            ImprimeDatos(provincias);
            string provinciaConMayorTemperatura = ProvinciaMayorTemperatura(provincias);
            lstImprimeDatos.Items.Add($"\nLa provincia con mayor temperatura es : {provinciaConMayorTemperatura}");
        }

        //METODOS

        public void InicializaProvincias(Provincia[] provincias) //Inicializa campos de provincias.
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i].NombreProvincia = "";
                provincias[i].PromedioTemperatura = 0;
                provincias[i].Temperaturas = new int[3];
            }
        }

        public void CargaProvincia(ref string provincia) // Carga nombre de una provincia
        {
            provincia = Interaction.InputBox("Ingrese Nombre de la provincia : ", "Provincia");
        }
        public void CargaTemperaturas(int[] temperaturas) //Carga las temperaturas de una provincia
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                temperaturas[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1}. Ingrese temperatura :","Temperaturas"));
            }
        }

        public int PromedioTemperaturas(int[] temperaturas) // Calcula el promedio de temperaturas de una provincia
        {
            int suma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
            }
            return suma / temperaturas.Count();
        }

        public void CargaDatos(Provincia provincia) // Carga datos de una provincia
        {
            CargaProvincia(ref provincia.NombreProvincia);
            CargaTemperaturas(provincia.Temperaturas);
        }

        public void CargaProvincias(Provincia[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                CargaDatos(provincias[i]);
                provincias[i].PromedioTemperatura = PromedioTemperaturas(provincias[i].Temperaturas);
            }
        }


        public string ProvinciaMayorTemperatura(Provincia[] provincias) //Busca la provincia con mayor temperatura
        {
            string provincia = "";
            int mayor = provincias[0].PromedioTemperatura;
            for (int i = 1; i < provincias.Length; i++)
            {
                if (mayor < provincias[i].PromedioTemperatura)
                {
                    provincia = provincias[i].NombreProvincia;
                    mayor = provincias[i].PromedioTemperatura;
                }
            }
                return provincia;
        }
        public void ImprimeProvincia(string provincia)  //Imprime nombre de la provincia
        {
            lstImprimeDatos.Items.Add(provincia);
        }

        public void ImprimeTemperaturas(int[] temperaturas) //Imprime las temperaturas de una provincia
        {  
                for (int i = 0; i < temperaturas.Length; i++)
                {
                    lstImprimeDatos.Items.Add(temperaturas[i]);
                }
        }

        public void ImprimeDatos(Provincia[] provincias)    //Imprime la Provincia y las temperaturas
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                ImprimeProvincia(provincias[i].NombreProvincia);
                ImprimeTemperaturas(provincias[i].Temperaturas);
            }
        }
    }
}
