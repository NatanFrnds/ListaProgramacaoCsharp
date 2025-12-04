using System;
public class Program
{
    public static void Main(string[] args)
    {
        double num1;
        Boolean par = true;
       
        Console.WriteLine("--- Calculadora de par ou impar ---");
        
        Console.Write("Digite o numero: ");

        num1 = double.Parse(Console.ReadLine());
        par = (num1 % 2 == 0.0 ? true : false);
        Console.WriteLine("\n--- Resultado ---");
        if (par) {
            Console.WriteLine("Par");
        } else {
            Console.WriteLine("impar");
        }
    }
}