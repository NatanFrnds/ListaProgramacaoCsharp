using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Não existe fatorial de número negativo!");
        }

        long resultado = 1;

        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }

        Console.WriteLine($"{num}! = {resultado}");
    }
}