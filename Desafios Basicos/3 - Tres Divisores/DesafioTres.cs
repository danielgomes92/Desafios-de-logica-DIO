/************************************
- Desafio
Dado um inteiro n, retorne true se n tiver exatamente tr�s divisores positivos.
Caso contr�rio, retorne false. O inteiro m � um divisor de n, se existe um inteiro k tal que n = k * m. 

- Entrada
O arquivo de entrada consiste em um inteiro n que ser� validada caso esteja sob as condi��es do desafio.

- Sa�da
A sa�da consistir� em um tipo booleano: true ou false. Como nos exemplos a baixo:

---- Exemplo 1 ----

- Entrada:
2

- Sa�da:
false

* Explica��o: o valor 2 possui apenas dois divisores: 1 e 2.

---- Exemplo 2 ----

- Entrada:
4

- Sa�da:
true

* Explica��o: o valor 4 tem tr�s divisores: 1, 2 e 4.
 ************************************/

using System;

class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            // TODO: Crie as outras condi��es necess�rias para a resolu��o do desafio:
            if (n % i ==     )
            {
                count++;
            }
            if (count >      )
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(count == 3);
    }
}