using Microsoft.VisualBasic;

namespace Atividade_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            double peso = 0, altura = 0;
            bool valido = false;

            
            while (!valido)
            {
                string entrada = Interaction.InputBox(
                    "Digite seu peso em kg:",
                    "Entrada - Peso");

                if (double.TryParse(entrada, out peso) && peso > 0)
                    valido = true;
                else
                    MessageBox.Show("Valor inválido! Informe um número maior que zero.");
            }

            valido = false;

           
            while (!valido)
            {
                string entrada = Interaction.InputBox(
                    "Digite sua altura em metros (ex: 1.75):",
                    "Entrada - Altura");

                if (double.TryParse(entrada, out altura) && altura > 0)
                    valido = true;
                else
                    MessageBox.Show("Valor inválido! Informe um número maior que zero.");
            }

           
            double imc = peso / (altura * altura);

            
            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else
            {
                classificacao = "Obesidade";
            }

            MessageBox.Show(
                $"Seu IMC é: {imc:F2}\nClassificação: {classificacao}",
                "Resultado do IMC");
        }
    }
}
