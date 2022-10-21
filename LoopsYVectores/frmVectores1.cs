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
    public partial class frmVectores1 : Form
    {
        string[] nombres;
        double[] nota1;
        double[] nota2;
        double[] nota3;
        double[] nota4;
        double[] promedios;
        double[] mayorNota;
        public frmVectores1()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            nombres = new string[4];
            nota1 = new double[3];
            nota2 = new double[3];
            nota3 = new double[3];
            nota4 = new double[3];
            
            PideNombres(nombres);
            CargaNotas(nota1);
            CargaNotas(nota2);
            CargaNotas(nota3);
            CargaNotas(nota4);


        }

        private void PideNombres(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese Nombre : ");
            }
        }

        private void CargaNotas(double[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToDouble(Interaction.InputBox("Ingrese Nota :"));
            }
        }

        private double CalculaPromedio(double[] notas)
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma+=notas[i];
            }
            return  suma / 3;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            double promedio1 = CalculaPromedio(nota1);
            double promedio2 = CalculaPromedio(nota2);
            double promedio3 = CalculaPromedio(nota3);
            double promedio4 = CalculaPromedio(nota4);
            double mayorNota1 = BuscaMayorNota(nota1);
            double mayorNota2 = BuscaMayorNota(nota2);
            double mayorNota3 = BuscaMayorNota(nota3);
            double mayorNota4 = BuscaMayorNota(nota4);

            promedios = new double[]{promedio1, promedio2, promedio3, promedio4};
            mayorNota = new double[] { mayorNota1, mayorNota2, mayorNota3, mayorNota4 };

            MuestraPromedios(nombres, promedios,mayorNota);
        }
        private void MuestraPromedios(string[] nombres, double[] promedios, double[] mayorNota)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                MessageBox.Show($"Promedio de {nombres[i]} : {promedios[i]}\nMayor Nota: {mayorNota[i]}");
                if (promedios[i] < 4) MessageBox.Show("Tenes que ir a recuperatorio.");
                else if (promedios[i] >4 && promedios[i]<7) MessageBox.Show("Bien!");
                else MessageBox.Show("Muy Bien");
            }
        }
        private double BuscaMayorNota(double[] notas)
        {
            double mayor = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i]>mayor) mayor=notas[i];
            }
            return mayor;
        }
    }
}
