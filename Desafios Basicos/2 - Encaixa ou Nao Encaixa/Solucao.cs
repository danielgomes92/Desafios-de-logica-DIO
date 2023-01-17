using System.IO;
using System.Linq;
using System;

class Program
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];

        for (int i = 0; i < qt; ++i)
        {
            v = Console.ReadLine().Split(" "); // Digitar as entradas para dividir entre duas Arrays e comparar se encaixam ou não
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length) // comparação de indices
                Console.WriteLine("nao encaixa");

            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");

            else
                Console.WriteLine("nao encaixa");
        }
    }
}