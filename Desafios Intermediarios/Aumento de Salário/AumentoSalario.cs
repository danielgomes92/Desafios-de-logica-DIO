/*
- B�sico
- Princ�pios B�sicos

- Desafio
A empresa ABC resolveu conceder um aumento de sal�rios a seus funcion�rios de acordo com a tabela abaixo:

- Sal�rio:
0 - 400.00
400.01 - 800.00
800.01 - 1200.00
1200.01 - 2000.00
Acima de 2000.00

- Percentual de Reajuste:
15%
12%
10%
7%
4%

Leia o sal�rio do funcion�rio e calcule e mostre o novo sal�rio, 
bem como o valor de reajuste ganho e o �ndice reajustado, em percentual.

---- Entrada ----
A entrada cont�m apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

---- Sa�da ----
Imprima 3 linhas na sa�da: o novo sal�rio, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

 
- Exemplo de Entrada:

> 400.00

- Exemplo de Sa�da:
Novo salario: 460.00
Reajuste ganho: 60.00
Em percentual: 15 %

> 800.01

- Exemplo de Sa�da:
Novo salario: 880.01
Reajuste ganho: 80.00
Em percentual: 10 %

> 2000.00

- Exemplo de Sa�da:
Novo salario: 2140.00
Reajuste ganho: 140.00
Em percentual: 7 %
 */

using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        double salario = 0.00;
        double reajuste = 0.00;
        double novoSalario = 0.00;
        double percentual = 0.00;

        salario = Convert.ToDouble(Console.ReadLine());

        //TODO: Complete os espa�os em branco com uma poss�vel solu��o para o problema:

        if ( < )
        {
            return;

        }
        else if ( <= )
        {
            percentual = ;
            reajuste =  ;
            novoSalario =   ;


        }
        else if (     <= )
        {
            percentual =   ;
            reajuste =  ;
            novoSalario = ;

        }
        else if (    <= )
        {
            percentual = ;
            reajuste =  ;
            novoSalario = ;

        }
        else if (   <= )
        {
            percentual =  ;
            reajuste =   ;
            novoSalario =  ;

        }
        else
        {
            percentual = ;
            reajuste = ;
            novoSalario = ;

        }

        Console.WriteLine("Novo salario: {0:0.00}",              );
        Console.WriteLine("Reajuste ganho: {0:0.00}",             );
        Console.WriteLine("Em percentual: {0} %", percentual *     );

    }
}