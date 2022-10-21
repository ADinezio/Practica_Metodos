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
    public partial class frmCaso4 : Form
    {
        public frmCaso4()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string figura = txtFigura.Text;
            double area = Area(figura);
            MessageBox.Show($"El area del {figura} es : {area}");
            
        }

        public double Area(string figura)
        {
            double area = 0;
            switch (figura)
            {
                case "rectangulo":

                    double recBase = Convert.ToDouble( Interaction.InputBox("Ingrese base del rectangulo : "));
                    double recAltura = Convert.ToDouble(Interaction.InputBox("Ingrese altura del rectangulo : "));
                    area= recBase * recAltura;  
                    break;

                case "circulo":
                    double radio = Convert.ToDouble(Interaction.InputBox("Ingrese radio del circulo : "));
                    area = Math.PI * Math.Pow(radio,2);
                    break;

                case "trapecio":
                    double trapBase = Convert.ToDouble(Interaction.InputBox("Ingrese base del rectangulo : "));
                    double trapAltura = Convert.ToDouble(Interaction.InputBox("Ingrese altura del rectangulo : "));
                    area= trapBase * trapAltura;    
                    break;
                default:
                    MessageBox.Show("Esa figura no existe");
                    break;
            }
            return area;
        }
    }
}
