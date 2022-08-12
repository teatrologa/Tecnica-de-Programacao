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
        int[] inteiros = new int[10];
        int contadorGeral = 0;
        
        
        public fmlEx1()
        {
            InitializeComponent();
        }

        private void fmlEx1_Load(object sender, EventArgs e)
        {
            //inteiros[0] = 20;
            //inteiros[1] = 117;
            //inteiros[2] = 33;
            //inteiros[3] = 40;
            //inteiros[4] = 55;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            int contadorInterno = contadorGeral;
            if (contadorGeral <= 9)
            {
                inteiros[contadorInterno] = Convert.ToInt32(tbxInsert.Text);
                contador();
                tbxInsert.Text = "";
                contadorGeral++;
                if (contadorInterno == 9)
                {
                    escreverNumero();
                    separarPar();
                    separarImp();
                }
            }
            
        }

        private int contador ()
        {
            var cont = Convert.ToInt32(lblContador.Text);
            lblContador.Text = (cont - 1).ToString();
            return cont; 
        }

        private void receberNum(int cont)
        {
            inteiros[cont] = Convert.ToInt32(tbxInsert.Text);
        }

        private void escreverNumero()
        {
            
             foreach (int i in inteiros)
             {
                lbxNumber.Items.Add(i);
                Array.Sort(inteiros);
             }
           
        }

        private void separarPar()
        {
            foreach (int i in inteiros)
            {
                if (i % 2 == 0)
                lbxNumPar.Items.Add(i);
                Array.Sort(inteiros);
            }
        }

        private void separarImp()
        {
           
            foreach (int i in inteiros)
            {
                if (i % 2 != 0)
                lbxNumImp.Items.Add(i);
                Array.Sort(inteiros);
            }
        }


        /*
         * Ideia:
         * 1. Fazer validação de entrada
         * 2. arrumar o layout explicando o que cada campo é etc
         * 
         */

    }
}
