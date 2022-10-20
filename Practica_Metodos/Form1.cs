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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double rectanguloBase = Convert.ToDouble(txtBase.Text);
            double rectanguloAltura = Convert.ToDouble(txtAltura.Text);
            
            double area = AreaRectangulo(rectanguloBase, rectanguloAltura);

            MessageBox.Show($"El area del rectangulo es : {area}");
        }

        public double AreaRectangulo(double baseRec, double alturaRec)
        {
            return baseRec * alturaRec;
        }
    }
}
