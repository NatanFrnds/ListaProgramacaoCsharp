using Microsoft.VisualBasic;
using System.Drawing;

namespace Atividade_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Matriz 3x5
            int[,] matriz = new int[3, 5];

            int maiorValor= int.MinValue;
            int linhaMaior = 0;
            int colunaMaior = 0;

            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 5; j++) {
                    string entrada = Interaction.InputBox(
                        $"Digite um numero inteiro para a posição{i}, {j}",
                        "Entrada de Dados"
                        );
                    int valor;

                    while (!int.TryParse(entrada, out valor)) {
                        entrada = Interaction.InputBox(
                            $"Entrada invalida!\nDigite um numero inteiro para a posição {i},{j}:","Erro"
                            );
                    }
                    matriz[i, j] = valor;

                    if (valor > maiorValor) { 
                    maiorValor= valor;
                        linhaMaior = i;
                        colunaMaior=j;
                            }

                }
            }
            MessageBox.Show(
                $"Maior valor encontrado: {maiorValor}\n"+
                $"Posição:Linha{linhaMaior}, Coluna{colunaMaior}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );


        }
    }
}
