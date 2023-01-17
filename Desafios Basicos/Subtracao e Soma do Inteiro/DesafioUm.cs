/***********************************
- Desafio
Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.

- Entrada
A entrada consiste em um número inteiro ( n );

- Saída
A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

Exemplo 1
Entrada - 234
Saída - 15

 ---- Explicação ---- 

Produto de dígitos = 2 * 3 * 4 = 24

Soma dos dígitos = 2 + 3 + 4 = 9

Resultado = 24 - 9 = 15
 ***********************************/

using System;

class DIO
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0)
        {
            int l = n % 10;
            p *= l;
            s +=      ;
            n /=      ;
        }

        Console.WriteLine(p - s);
    }
}