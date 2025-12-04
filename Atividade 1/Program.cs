using System;
public class Program
{
    public static void Main(string[] args)
    {
        double nota1, nota2, nota3, nota4, media;
// 1. ENTRADA DE DADOS (usando Console.ReadLine e conversão)
Console.WriteLine("--- Calculadora de Média (CLI) ---");
// Leitura da 1a nota
Console.Write("Digite a primeira nota: ");
// Tenta converter a string lida para double. Se for inválido, o programa irá
nota1 = double.Parse(Console.ReadLine());
// Leitura da 2a nota
Console.Write("Digite a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
// Leitura da 3a nota
Console.Write("Digite a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());
        Console.Write("Digite a qaurta nota: ");
        nota4 = double.Parse(Console.ReadLine());
        // 2. PROCESSAMENTO (Cálculo da Média)
        media = (nota1 + nota2 + nota3+nota4) / 4.0;
// 3. SAÍDA DE DADOS (Exibição do resultado)
Console.WriteLine("\n--- Resultado ---");
Console.WriteLine($"A média aritmética das notas é: {media:F2}"); // :F2 formata para 2 casas decimais
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o console
}
}