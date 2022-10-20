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
    public partial class frmCaso3 : Form
    {
        public frmCaso3()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            Tabla(num);
        }

        public void Tabla (int num)
        {
            for(int i = 1; i <= 12; i++)
            {
                MessageBox.Show($"{num} x {i} = {num * i}");
            }
        }
    }
}
