using System;

class FibonacciSequence
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isFibonacci = IsFibonacci(number);

        if (isFibonacci)
         Console.WriteLine($"O Número {number} faz parte da sequência de Fibonacci.");
        
        else
         Console.WriteLine($"O Número {number} não faz parte da sequência de Fibonacci.");
        
    }

    static bool IsFibonacci (int number)
    {
        int a = 0;
        int b = 1;

        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == number;
    }
}