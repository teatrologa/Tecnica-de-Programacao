using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCalcSimples_Click(object sender, EventArgs e)
        {
            //Application.Run(new FmlCalculadoraSimples());
            FmlCalculadoraSimples newCalc = new FmlCalculadoraSimples();
            newCalc.Show();
        }

        private void btnCalcImc_Click(object sender, EventArgs e)
        {
            fmlCalculadoraIMC newCalc = new fmlCalculadoraIMC();
            newCalc.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
