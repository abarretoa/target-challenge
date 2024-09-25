using System;

class ContadordeLetras
{
    static void Main(string[] args)
    {
        Console.Write("Digite a palavra: ");
        string palavra = Console.ReadLine();

        int count = ContadorDeLetras(palavra, 'a');

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vezes na palavra.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na palavra.");
        }
    }

    static int ContadorDeLetras(string palavra, char letter)
    {
        int count = 0;
        foreach (char c in palavra.ToLower())
        {
            if (c == letter || c == char.ToUpper(letter))
            {
                count++;
            }
        }
        return count;
    }
}