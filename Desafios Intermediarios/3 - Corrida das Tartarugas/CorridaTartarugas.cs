/*
- Desafio
A corrida de tartarugas � um esporte que cresceu muito nos �ltimos anos,
fazendo com que v�rios competidores se dediquem a capturar tartarugas r�pidas, 
e treina-las para faturar milh�es em corridas pelo mundo. Por�m a tarefa de 
capturar tartarugas n�o � uma tarefa muito f�cil, pois quase todos esses r�pteis s�o bem lentos.
Cada tartaruga � classificada em um n�vel dependendo de sua velocidade:

N�vel 1: Se a velocidade � menor que 10 cm/h .
N�vel 2: Se a velocidade � maior ou igual a 10 cm/h e menor que 20 cm/h .
N�vel 3: Se a velocidade � maior ou igual a 20 cm/h .

Sua tarefa � identificar qual o n�vel de velocidade da tartaruga mais veloz de um grupo.

Entrada:
A entrada consiste de m�ltiplos casos de teste, e cada um consiste em duas linhas: 
A primeira linha cont�m um inteiro L (1 <= L <= 500) representando o n�mero de tartarugas do grupo, 
e a segunda linha cont�m L inteiros Vi (1 <= Vi <= 50) representando as velocidades de cada tartaruga do grupo.

---- Exemplo de Entrada	---- 
10
10 10 10 10 15 18 20 15 11 10

10
1 5 2 9 5 5 8 4 4 3

10
19 9 1 4 5 8 6 11 9 7

---- Exemplo de Sa�da ----
3
1
2
*/
using System;

class Desafio
{
    public static void Main()
    {
        int quantidadeEntradas = 3;

        while (quantidadeEntradas > 0)
        {
            var numeroQuantidade = Int32.Parse(Console.ReadLine());

            if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
            {
                string[] tartarugas = Console.ReadLine().Split(" ");
                var maiorVelocidade = Int32.Parse(tartarugas[0]);

                // TODO: Crie as outras condi��es necess�rias para a resolu��o do desafio:
                for (                                           )
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);

                    if (                                          )
                    {
                        maiorVelocidade = tartaruga;
                    }
                }

                if (                            < 10)
                {
                    Console.WriteLine(1);
                }
                else if (                            >= 10 &&                            < 20)
                {
                    Console.WriteLine(2);
                }
                else if (                                        >= 20)
                {
                    Console.WriteLine(3);
                }
                quantidadeEntradas--;
            }
            else
            {
                Console.WriteLine("Insira um n�mero entre 1 e 500");
            }
        }
    }
}