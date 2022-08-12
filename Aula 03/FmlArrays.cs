namespace Aula_03
{
    public partial class FmlArraysMenu : Form
    {
        public FmlArraysMenu()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            this.Hide(); //isso esconde o menu principal para poder abrir o novo form
            fmlEx1 newEx = new fmlEx1();
            newEx.ShowDialog(); //existe 2 formas de chamar esse novo form Show e ShowDialog
                                //porém apenas com o ShowDialog quando eu fecho o form ele chama o menu principal automaticamente
                                //caso contrário, ele abre os dois forms
            this.Show(); //isso faz o menu principal (este aqui) abrir novamente
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {

        }

        private void btnEx3_Click(object sender, EventArgs e)
        {

        }

        private void btnEx4_Click(object sender, EventArgs e)
        {

        }

        private void FmlArraysMenu_Load(object sender, EventArgs e)
        {

        }
    }
}