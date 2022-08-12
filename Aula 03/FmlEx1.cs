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
    public partial class fmlEx1 : Form
    {
        public int[] Inteiros = new int[10];
        public fmlEx1()
        {
            InitializeComponent();
        }

        private void fmlEx1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            contador();
            receberNumero();
            escreverNumero();
            tbxInsert.Text = "";
        }

        private int contador ()
        {
            var cont = Convert.ToInt32(lblContador.Text);
            lblContador.Text = (cont - 1).ToString();
            return cont; 
        }
        private void receberNumero()
        {
            for (int i = 10; i < 0; i--)
            {
                int setNum = Convert.ToInt32(tbxInsert.Text);
                Inteiros[i] = setNum;
            }
        }
        private void escreverNumero()
        {
            foreach (int n in Inteiros)
            {
                lbxNumber.Items.Add(Inteiros[n]);
            }
        }

        private void separarPar()
        {

        }


      
    }
}
