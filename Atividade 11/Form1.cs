using Microsoft.VisualBasic;

namespace Atividade_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matriz = new int[4, 3];
            int positivos = 0, negativos = 0, zeros = 0;

            // Preenchendo a matriz com InputBox
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bool valido = false;

                    while (!valido)
                    {
                        string entrada = Interaction.InputBox(
                            $"Digite um valor inteiro para a posição [{i},{j}]:",
                            "Entrada de Dados");

                        if (int.TryParse(entrada, out matriz[i, j]))
                        {
                            valido = true;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido! Digite um número inteiro.");
                        }
                    }
                }
            }

            // Contagem dos elementos
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] > 0)
                        positivos++;
                    else if (matriz[i, j] < 0)
                        negativos++;
                    else
                        zeros++;
                }
            }

            // Exibindo o resultado
            MessageBox.Show(
                $"Total de positivos: {positivos}\n" +
                $"Total de negativos: {negativos}\n" +
                $"Total de zeros: {zeros}",
                "Resultado");
        }
    }
}

