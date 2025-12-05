using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        int nums = 0;
        Console.Write("Digite dez números inteiros positivos: ");
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[10];
        int ca = 0;
        int cb = 1;
        int cont = 0;
       
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ca;
                ca += 2;           
            }
        
        for (int i = 0; i < b.Length; i++)
        {
            b[i] = cb;
            cb += 2;
        }



        int conta = 0;
        int contb = 0;

        for (int i = 0; i < c.Length; i++)
        {
            if (i % 2 == 0)
            {
                c[i] = a[conta];
                conta++;
            }
            else
            {
                c[i] = b[contb];
                contb++;
            }
        }

        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i] + ",");
        }
    }
}
