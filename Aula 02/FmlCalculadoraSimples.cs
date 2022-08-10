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
    public partial class FmlCalculadoraSimples : Form
    {
        public FmlCalculadoraSimples()
        {
            InitializeComponent();
        }
        public decimal Result  { get; set; }
        public decimal Valor { get; set; }

        private Operation SelOperation { get; set; }

        private enum Operation
        {
            More,
            Less,
            Divide,
            Multiply
        }

        private void fmlCalculadoraSimples_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            //if (!lblHistoric.Text.Contains("."))
            //{
            //    lblHistoric.Text += ",";
            //}
            
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += " + ";
            //SelOperation = Operation.More;
            //Valor = Convert.ToDecimal(txbOperation.Text);
            
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += " - ";
            //SelOperation = Operation.Less;
            //Valor = Convert.ToDecimal(txbOperation.Text);
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += " / ";
            //SelOperation = Operation.Divide;
            //Valor = Convert.ToDecimal(txbOperation.Text);
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblHistoric.Text += " * ";
            //SelOperation = Operation.Multiply;
            //Valor = Convert.ToDecimal(txbOperation.Text);
            
        }


        private void btnResult_Click(object sender, EventArgs e)
        {
            //switch (SelOperation)
            //{
            //    case Operation.More:
            //        Result = Valor + Convert.ToDecimal(txbOperation.Text);
            //        break;
            //    case Operation.Less:
            //        Result = Valor - Convert.ToDecimal(txbOperation.Text);
            //        break;
            //    case Operation.Divide:
            //        Result = Valor / Convert.ToDecimal(txbOperation.Text);
            //        break;
            //    case Operation.Multiply:
            //        Result = Valor * Convert.ToDecimal(txbOperation.Text);
            //        break;
            //}

            DataTable Calc = new DataTable();
            var result = Calc.Compute(lblHistoric.Text, "");

            lblResult.Text = result.ToString();
            //txbOperation.Text = "";
            
            
            
            
            
            /*
             * Ideia: fazer as operações em pares e reaproveitar o valor "acima".
             * v1 + v2 = lblresult >> lblresult = v1 + v2
             * se for setando sempre, dá pra ver o que a pessoa vai fazer e manter o registro do que ela está
             * escrevendo na operação (só não dá pra arrumar)
             * ai quando a pessoa der igual (=) mudamos a cor das coisas (resultado preto > laranja)
             */
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblHistoric.Text = "";
            Valor = 0;
            Result = 0;
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuPrincipal = new Menu();
            menuPrincipal.Show();
        }
    }
}

//private void txbDisplay_KeyPress(object sender, KeyPressEventArgs e)
//{
//    if ("+-*/".Contains(e.KeyChar))
//    {
//        Operation(e.KeyChar.ToString());
//    }
//    e.Handled = !char.IsDigit(e.KeyChar);
//}