using Microsoft.VisualBasic;

namespace Atividade_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 0;
            bool valido = false;

            // -------------------- Entrada do número --------------------
            while (!valido)
            {
                string entrada = Interaction.InputBox(
                    "Digite um número inteiro positivo:",
                    "Verificar Número Primo"
                );

                if (int.TryParse(entrada, out n) && n > 0)
                    valido = true;
                else
                    MessageBox.Show("Valor inválido! Digite um número INTEIRO e MAIOR que zero.");
            }

            // -------------------- Verificar se é primo --------------------
            bool primo = true;

            if (n <= 1)
            {
                primo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            // -------------------- Exibir resultado --------------------
            MessageBox.Show(
                $"Número: {n}\nÉ primo? {primo}",
                "Resultado"
            );
        }
    }
}