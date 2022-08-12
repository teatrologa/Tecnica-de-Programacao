using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03
{
    public partial class fmlEx3 : Form
    {
        public fmlEx3()
        {
            InitializeComponent();
        }

        private void fmlEx3_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int linha = Convert.ToInt32(tbxLinha.Text);
            int coluna = Convert.ToInt32(tbxColuna.Text);
            string[ , ] matriz = new string[ linha, coluna ];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = "*";
                }
            }
        }
    }
}
