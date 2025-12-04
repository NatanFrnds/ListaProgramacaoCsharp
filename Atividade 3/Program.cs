using System;
public class Program
{
    public static void Main(string[] args)
    {
        double num1, num2;

        Console.WriteLine("--- Calculadora de Celsius para Fahrenheit ---");

        Console.Write("Digite a temperatura em Celsius: ");
        num1 = double.Parse(Console.ReadLine());
        num2 = num1 * 1.8 + 32;

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine("Temperatura em Fahrenheit é: " + num2);
    }
}