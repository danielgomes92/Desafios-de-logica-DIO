using System;

class DIO
{
	static void Main(string[] args)
	{

		int n = int.Parse(Console.ReadLine()); // Digite o valor de entrada para realizar a opera��o.
		int p = 1, s = 0;
		while (n > 0)
		{
			int l = n % 10;
			p *= l;
			s += l;
			n /= 10; // Divis�o do resultado at� zerar o resto das divis�es acima.
		}

		Console.WriteLine(p - s);
	}
}