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
            gbxAreaPlot.Text = $"Essa é uma matriz {linha}x{coluna}.";
            string[ , ] matriz = new string[ linha, coluna ];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string linhaTex = ""; //você precisa concatenar os valores das colunas em uma string de linha,
                                      //por isso você deve criar essa variavel antes de iniciar o for de coluna.
                                      //Lá dentro você faz a concatenação de valores usando o +=.
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = "*";
                    linhaTex += " " + matriz[i, j] + " "; //Aqui você está concatenando os valores das colunas em uma linha "i" específica.
                }

                lboxMatriz.Items.Add(linhaTex); //Agora tendo a linha criada, você aciciona ela, e faz isso linha por linha no loop.
            }

            tbxColuna.Text = "";
            tbxLinha.Text = "";
        }
    }
}
