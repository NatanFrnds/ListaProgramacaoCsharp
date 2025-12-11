using Microsoft.VisualBasic;

namespace Atividade_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            int[,] matriz = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int linhaEscolhida=0;
            bool valido = false;

           
            while (!valido)
            {
                string entrada = Interaction.InputBox(
                    "Digite o índice da linha que deseja somar (0, 1 ou 2):",
                    "Escolha da Linha");

                if (int.TryParse(entrada, out linhaEscolhida) &&
                    linhaEscolhida >= 0 && linhaEscolhida <= 2)
                {
                    valido = true;
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Digite 0, 1 ou 2.");
                }
            }

            
            int soma = 0;
            for (int j = 0; j < 4; j++)
            {
                soma += matriz[linhaEscolhida , j];
            }

           
            MessageBox.Show($"A soma dos elementos da linha {linhaEscolhida} é: {soma}",
                            "Resultado");
        }
    }
}
