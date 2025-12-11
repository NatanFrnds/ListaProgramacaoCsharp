using Microsoft.VisualBasic;

namespace Atividade_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matrizOriginal = new int[2, 3];
            int[,] matrizTransposta = new int[3, 2];

            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bool valido = false;

                    while (!valido)
                    {
                        string entrada = Interaction.InputBox(
                            $"Digite o valor para a posição [{i},{j}]:",
                            "Entrada da Matriz Original");

                        if (int.TryParse(entrada, out matrizOriginal[i, j]))
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

           
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizTransposta[j, i] = matrizOriginal[i, j];
                }
            }

            
            string textoOriginal = "Matriz Original (2x3):\n";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textoOriginal += matrizOriginal[i, j] + "\t";
                }
                textoOriginal += "\n";
            }

            string textoTransposta = "Matriz Transposta (3x2):\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    textoTransposta += matrizTransposta[i, j] + "\t";
                }
                textoTransposta += "\n";
            }

           
            MessageBox.Show(textoOriginal, "Matriz Original");
            MessageBox.Show(textoTransposta, "Matriz Transposta");
        }
    }
}
