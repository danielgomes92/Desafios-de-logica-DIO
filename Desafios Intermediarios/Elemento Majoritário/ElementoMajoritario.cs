/*
- Desafio
Dado um array nums de tamanho n, retorne o elemento majorit�rio, 
isto �, o elemento que aparece o maior n�mero de vezes no seu array.

- Entrada
A primeira linha da entrada dever� ser o n�mero referente ao tamanho do seu array. 
As demais linhas nums ser�o os valores da sua array.

- Sa�da
A sa�da dever� retornar o n�mero que aparece o maior n�mero de vezes 
na sua array, ou seja, o elemento majorit�rio.

---- Exemplo 1 ----

- Entrada:
3
7
5
7

- Sa�da:
7

---- Exemplo 2 ----

- Entrada:
9
2
1
1
1
2
2
2
1
2

- Sa�da:
2
 */
using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        // TODO: Crie as outras condi��es necess�rias para a resolu��o do desafio:
        for (                              )
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));

    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (                   )
        {
            if (                    )
            {
                major = nums[i];
                count;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return;
    }
}