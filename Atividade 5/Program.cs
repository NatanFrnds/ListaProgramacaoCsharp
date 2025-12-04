using System;

class Program
{
    static void Main()
    {



        Console.Write("Digite um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());
        int nums = 1;
        int numa = 1;
        int temp = 0;
        String numeros = "0,1,1";
        for (int i = 0; i < num; i++)
        {
            if (i < 2)
            {
                numa = i;
            }
            else if (i == 2) {
                numa = 1;
            } else { 
                temp = nums;
                nums = numa;
                numa = temp + nums;
            }

            Console.WriteLine(numa);

        }
    }
}