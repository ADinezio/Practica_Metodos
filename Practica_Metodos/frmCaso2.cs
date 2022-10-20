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
    public partial class frmCaso2 : Form
    {
        public frmCaso2()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Validacion();
        }

        public void Validacion()
        {
            int edad = Int32.Parse(txtEdad.Text);

            if (edad <= 0) MessageBox.Show("ERROR.");
            else if (edad < 18) MessageBox.Show("Menor de edad.");
            else if (edad >= 18 && edad < 60) MessageBox.Show("Mayor de edad");
            else MessageBox.Show("Adulto mayor.");
        }
    }
}
