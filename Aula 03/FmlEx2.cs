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
    public partial class fmlEx2 : Form
    {
        int[] pontuacao = new int[3];
        
        public fmlEx2()
        {
            InitializeComponent();
        }

        private void fmlEx2_Load(object sender, EventArgs e)
        {
            pontuacao[0] = 10;
            pontuacao[1] = 4;
            pontuacao[2] = 7;
            //Array.Sort(pontuacao);

            //int[] podio = new int[pontuacao.Length];
            //for (int i = 0; i < pontuacao.Length; i++)
            //{
            //    podio[i] = i + 1;
            //}

        }
        

    private void btnGo_Click(object sender, EventArgs e)
        {
            foreach (int i in pontuacao)
            {
                lbxPontuacao.Items.Add(i);
            }
            
            
            
        }
    }
}
