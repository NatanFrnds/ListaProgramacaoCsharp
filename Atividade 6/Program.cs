using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite cinco números inteiros positivos: ");
        int[] num = new int[5];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            }
        for (int i = (num.Length-1); i >=0; i--) { 
        Console.Write(num[i]+" ");
        }
    }
}