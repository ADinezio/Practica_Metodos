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
    public partial class frmVectores3 : Form
    {
        string[] nombreOperarios;
        double[] salarios1;
        double[] salarios2;
        double[] salarios3;
        double[] salarios4;
        double[] totalSuledos;

        public frmVectores3()
        {
            InitializeComponent();
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            nombreOperarios = new string[4];
            CargaOperarios(nombreOperarios);
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            salarios1 = new double[3];
            salarios2 = new double[3];
            salarios3 = new double[3];
            salarios4 = new double[3];

            CargaSalarios(salarios1);
            CargaSalarios(salarios2);
            CargaSalarios(salarios3);
            CargaSalarios(salarios4);

        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            double total1 = CalculaTotalSueldo(salarios1);
            double total2 = CalculaTotalSueldo(salarios2);
            double total3 = CalculaTotalSueldo(salarios3);
            double total4 = CalculaTotalSueldo(salarios4);
            totalSuledos = new double[4] {total1,total2, total3, total4};
            MostrarSalarioTotal(nombreOperarios,totalSuledos);
            int pos = OperarioMayorSueldo(totalSuledos);
            MessageBox.Show($"El Operario con mayor sueldo es : {nombreOperarios[pos]}");
            
        }

        private void CargaOperarios(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese Nombre: ");
            }
        }
        private void CargaSalarios(double[] salarios)
        {
            for (int i = 0; i < salarios.Length; i++)
            {
                salarios[i] = Convert.ToDouble(Interaction.InputBox($"{i+1}.Ingrese salario:"));
            }
        }
        
        private double CalculaTotalSueldo(double[] salario)
        {   
            double total = 0;
            for (int i = 0; i < salario.Length; i++)
            {
                total+=salario[i];
            }
            return total;
        }


        private void MostrarSalarioTotal(string[] nombres, double[] salarios)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                MessageBox.Show($"{nombres[i]} : $ {salarios[i]}");
            }
        }
        private int OperarioMayorSueldo(double[] salarios)
        {
            int posMayor = 0;
            double mayor = salarios[0];
            for (int i = 1; i < salarios.Length; i++)
            {
                if (mayor < salarios[i])
                {
                    mayor = salarios[i];
                    posMayor = i;
                }
            }
            return posMayor;
        }

    }
}
