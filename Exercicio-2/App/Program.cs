using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine()!;

        int quantidadeA = entrada.Count(c => c == 'a' || c == 'A');

        bool existeA = quantidadeA > 0;

        Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) " +
                          $"{(existeA ? "existe" : "não existe")} na string.");

        Console.WriteLine($"Quantidade de vezes que a letra 'a' ocorre: {quantidadeA}");
    }
}
