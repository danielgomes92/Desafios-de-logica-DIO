/***********************************
- Desafio
Dado um n�mero inteiro ( n ) , retorne a diferen�a entre o produto de seus d�gitos e a soma de seus d�gitos.

- Entrada
A entrada consiste em um n�mero inteiro ( n );

- Sa�da
A sa�da consiste na multiplica��o do produto dos d�gitos ( n ), a soma de seus d�gitos e a diferen��o entre o produto e a soma, como no exemplo a baixo: 

Exemplo 1
Entrada - 234
Sa�da - 15

 ---- Explica��o ---- 

Produto de d�gitos = 2 * 3 * 4 = 24

Soma dos d�gitos = 2 + 3 + 4 = 9

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