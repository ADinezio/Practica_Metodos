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
            public int TemperaturaPromedio;
            
        }
        Provincia[] provincias;

        public frmVectores6()
        {
            InitializeComponent();
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            provincias = new Provincia[4];
            InicializaCampos(provincias);
            CargaDatos(provincias);
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MuestraDatos(provincias);
            string provMayorTempo=ProvinciaConMayorTemp(provincias);
            lstImprimeDatos.Items.Add($"La provincia con mayor temperatura es : {provMayorTempo}");

        }

        //METODOS

        public void InicializaCampos(Provincia[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i].NombreProvincia = "";
                provincias[i].Temperaturas = new int[3];
                provincias[i].TemperaturaPromedio = 0;
            }
        }

        public string CargaNombreProvincia()
        {
            string nombre= Interaction.InputBox("Ingrese nombre de la provincia", "Provincia");
            return nombre;
        }
        public void CargaTemperaturas(Provincia provincia)
        {
            for (int i = 0; i < provincia.Temperaturas.Length; i++)
            {
                provincia.Temperaturas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese temperatura", "Temperaturas"));
            }
        }

        public void CargaDatos(Provincia[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
               provincias[i].NombreProvincia=CargaNombreProvincia();
                CargaTemperaturas(provincias[i]);
                provincias[i].TemperaturaPromedio = PromedioTemperatura(provincias[i].Temperaturas);
            }
        }

        public void MuestraNombreProvincias(Provincia provincia)
        {
            lstImprimeDatos.Items.Add(provincia.NombreProvincia);
        }
        public void MuestraTemperaturas(Provincia provincia)
        {
            for (int i = 0; i < provincia.Temperaturas.Length; i++)
            {
                lstImprimeDatos.Items.Add(provincia.Temperaturas[i]);
            }
        }
        public void MuestraDatos(Provincia[] provincias)
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                MuestraNombreProvincias(provincias[i]);
                MuestraTemperaturas(provincias[i]);
            }
        }

        public int PromedioTemperatura(int[] temperaturas)
        {
            int suma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                suma += temperaturas[i];
            }
            return suma / temperaturas.Count();
        }

        public string ProvinciaConMayorTemp(Provincia[] provincias)
        {
            int mayor = provincias[0].TemperaturaPromedio;
            string prov = provincias[0].NombreProvincia;
            for (int i = 1; i < provincias.Length; i++)
            {
                if (mayor < provincias[i].TemperaturaPromedio)
                {
                    mayor=provincias[i].TemperaturaPromedio;
                    prov = provincias[i].NombreProvincia;
                }
            }
            return prov;
        }

    }
}
