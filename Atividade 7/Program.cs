using System;
class Program
{
    static void Main()
    {
        int nums = 0;
        Console.Write("Digite dez números inteiros positivos: ");
        int[] num = new int[10];
        int cont = 0;
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        for (int i = (num.Length - 1); i >= 0; i--)
        {
            nums += num[i];
        }
        int media = nums / num.Length;
        Console.Write(media + " é a media \n");
        for (int i = (num.Length - 1); i >= 0; i--)
        {
            if (num[i] > media)
            {
                cont++;
            }
           
        }
        Console.Write(cont + " numeros são superiores a media");
        int[] supm = new int[cont];
    }
}