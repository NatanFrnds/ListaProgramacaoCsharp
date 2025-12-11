using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade19
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Demonstração de Polimorfismo (Vetores)");
            sb.AppendLine("");

            Cachorro rex = new Cachorro { Nome = "Rex" };
            Gato mia = new Gato { Nome = "Mia" };
            Animal desconhecido = new Animal { Nome = "Pássaro" };

            Animal[] fazenda = new Animal[] { rex, mia, desconhecido };

            sb.AppendLine("Iterando sobre o vetor de animais:");
            sb.AppendLine("");

            foreach (Animal animal in fazenda)
            {
                string acao = animal.EmitirSom();

                sb.AppendLine($"Animal: {animal.Nome}");
                sb.AppendLine($"Ação: {acao}");
                sb.AppendLine($"Tipo Real: {animal.GetType().Name}");
                sb.AppendLine("");
            }

            sb.AppendLine("");

            MessageBox.Show(sb.ToString(), "Polimorfismo (Herança e Sobrescrita)");
        }
    }

    public class Animal
    {
        public string Nome { get; set; }

        public virtual string EmitirSom()
        {
            return "Fazendo algum som genérico...";
        }
    }

    public class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Latindo...";
        }
    }

    public class Gato : Animal
    {
        public override string EmitirSom()
        {
            return "Miando...";
        }
    }
}