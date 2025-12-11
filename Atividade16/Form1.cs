namespace Atividade16
{
    public partial class Form1 : Form
    {
        decimal saldo = 1000m;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool continuar = true;

            while (continuar)
            {
                int opcao = cmbOpcoes.SelectedIndex + 1;

                switch (opcao)
                {
                    case 1: // Sacar
                        if (decimal.TryParse(txtValor.Text, out decimal valorSaque))
                        {
                            if (valorSaque <= 0)
                            {
                                lblMensagem.Text = "Valor inválido.";
                            }
                            else if (valorSaque > saldo)
                            {
                                lblMensagem.Text = "Saldo insuficiente!";
                            }
                            else
                            {
                                saldo -= valorSaque;
                                lblMensagem.Text = $"Saque realizado! Novo saldo: R$ {saldo:F2}";
                            }
                        }
                        else
                        {
                            lblMensagem.Text = "Digite um valor válido.";
                        }
                        continuar = false;
                        break;

                    case 2: // Depositar
                        if (decimal.TryParse(txtValor.Text, out decimal valorDeposito) && valorDeposito > 0)
                        {
                            saldo += valorDeposito;
                            lblMensagem.Text = $"Depósito realizado! Novo saldo: R$ {saldo:F2}";
                        }
                        else
                        {
                            lblMensagem.Text = "Digite um valor válido para depósito.";
                        }
                        continuar = false;
                        break;

                    case 3: // Consultar Saldo
                        lblMensagem.Text = $"Saldo atual: R$ {saldo:F2}";
                        continuar = false;
                        break;

                    case 4: // Sair
                        lblMensagem.Text = "Sistema encerrado.";
                        Application.Exit();
                        break;

                    default:
                        lblMensagem.Text = "Escolha uma opção válida.";
                        continuar = false;
                        break;
                }
            }
        }
    }
}
