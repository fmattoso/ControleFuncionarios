using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(lblSim.Text) + 1;
            lblSim.Text = Convert.ToString(valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(lblNao.Text) + 1;
            lblNao.Text = Convert.ToString(valor);
        }
    }
}
