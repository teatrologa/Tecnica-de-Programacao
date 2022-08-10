namespace Aula_02
{
    public partial class fmlCalculadoraIMC : Form
    {
        public fmlCalculadoraIMC()
        {
            InitializeComponent();
        }


        private void fmlCalculadoraIMC_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double massa, altura;
            massa = Convert.ToDouble(textBox2.Text);
            altura = Convert.ToDouble(textBox1.Text);
            
            var (numeroImc, stringImc) = CalcularImc(massa, altura);

            label5.Text = $"Seu valor de IMC é: {numeroImc}\nSeu diagnóstico é: {stringImc}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = String.Empty;

            textBox1.Focus();
        }

        private (double, string) CalcularImc (double massa, double altura)
        {
            double imc;
            imc = (massa / (altura * altura));

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido" //o underline _ é usado como se fosse um defalt
            };

            return (imc, resultado); //na mesma ordem que foi escrito no inicio do metodo
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuPrincipal = new Menu();
            menuPrincipal.Show();
        }
    }
}