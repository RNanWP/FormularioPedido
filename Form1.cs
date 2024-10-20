namespace CheckButton_e_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string tamanho = "";
            if (rbPequena.Checked)
                tamanho = "Pequena";
            else if (rbMedia.Checked)
                tamanho = "Média";
            else if (rbGrande.Checked)
                tamanho = "Grande";

            string pagamento = "";
            if (rbDinheiro.Checked)
                pagamento = "Dinheiro";
            if (rbPix.Checked)
                pagamento = "Pix";
            else if (rbCartao.Checked)
                pagamento = "Cartão";

            List<string> adicionaisList = new List<string>();
            if (chkQueijo.Checked)
                adicionaisList.Add("Queijo Extra");
            if (chkBorda.Checked)
                adicionaisList.Add("Borda Recheada");
            if (chkBacon.Checked)
                adicionaisList.Add("Bacon");

            string adicionais = string.Join(", ", adicionaisList);

            string sabor = "";
            if (cmbSabor.SelectedItem != null)
            {
                sabor = cmbSabor.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Nenhum sabor selecionado. Por favor, selecione um sabor de pizza.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resumo = $"Tamanho: {tamanho}\nSabor: {sabor}\n" +
                            $"Adicionais: {adicionais}\n" +
                            $"Forma de Pagamento: {pagamento}";

            MessageBox.Show(resumo, "Resumo do Pedido");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSabor_Enter(object sender, EventArgs e)
        {

        }
    }
}
