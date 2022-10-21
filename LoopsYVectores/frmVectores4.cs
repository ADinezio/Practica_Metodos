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
    public partial class frmVectores4 : Form
    {
        string[] personas;
        int[] edades;
        public frmVectores4()
        {
            InitializeComponent();
        }

        private void btnCargaPersonas_Click(object sender, EventArgs e)
        {
            personas = new string[5];
            CargaPersonas(personas);
        }

        private void btnCargaEdades_Click(object sender, EventArgs e)
        {
            edades = new int[5];
            CargaEdades(edades);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MuestraMayoresEdad(edades, personas);
        }

        private void CargaPersonas(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i]=Interaction.InputBox($"{i + 1}. Ingrese Nombre : ");
            }
        }

        private void CargaEdades(int[] edades)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                edades[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1} Ingrese Edad : "));
            }
        }

        private void MuestraMayoresEdad(int[] edades, string[] nombres)
        {
            for (int i = 0; i < edades.Length; i++)
            {
                if (edades[i]>=18)
                {
                    lstMayoresEdad.Items.Add(nombres[i]);
                }
            }
        }

    }
}
