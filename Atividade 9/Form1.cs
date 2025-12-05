namespace Atividade_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Matriz 4x4
            int[,] matriz = {
{  1,  2,  3,  4 },
{  5,  6,  7,  8 },
{  9, 10, 11, 12 },
{ 13, 14, 15, 16 }
};

            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;
            int N = 4;

            // Soma da diagonal principal
            for (int i = 0; i < N; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
            }

            // Soma da diagonal 2
            for (int i = 0; i < N; i++)
            {
                somaDiagonalSecundaria += matriz[i, N - 1 - i];
            }

            //  resultado
            string mensagem =
            $"Matriz 4x4:\n" +
            "1  2  3  4\n" +
            "5  6  7  8\n" +
            "9 10 11 12\n" +
            "13 14 15 16\n\n" +
            $"Soma da Diagonal Principal: {somaDiagonalPrincipal}\n" +
            $"Soma da Diagonal Secundária: {somaDiagonalSecundaria}";

            MessageBox.Show(mensagem, "Resultados das Diagonais");
        }
    }
 }
