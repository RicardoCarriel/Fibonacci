using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;
        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c != num)
        {
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        }
    }
}