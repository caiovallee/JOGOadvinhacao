using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGOadvinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicio 
            char opcao = ' ';



            while (opcao != 'n' && opcao != 'N')
            {
                int Dificuldade = 0;
                Random valor = new Random();
                int numeroSecreto = valor.Next(1, 20);
                int pontuacao = 1000;
                int tentativaAtual = 1;
                int tentativa = 1000;
                while (tentativa > 0)
                {
                    //SELECAO DIFICULDADE
                    while (Dificuldade != 1 && Dificuldade != 2 && Dificuldade != 3)
                    {
                        Console.WriteLine("Bem vindo(a) ao Jogo da Advinhação");
                        Console.WriteLine();
                        Console.WriteLine("Escolha o nível de dificuldade:");
                        Console.WriteLine("(1) Facil (2) Médio (3) Difícil");
                        Console.WriteLine("Escolha:");
                        Dificuldade = int.Parse(Console.ReadLine());
                    }


                    switch (Dificuldade)
                    {
                        case 1:
                            //REPETICAO BASEADO TENTATIVAS E DIFICULDADE
                            for (tentativa = 15; tentativa > 0; tentativa--)
                            {
                                Console.WriteLine($"Tentativa {tentativaAtual} de 15");
                                Console.WriteLine($"Pontuacao atual = {pontuacao}");
                                Console.WriteLine();
                                Console.WriteLine($"qual a sua {tentativaAtual} tentiva ?");
                                int numeroChutado = int.Parse(Console.ReadLine());
                                //incremento variaveis apos erro
                                if (numeroChutado < numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é menor que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //incremento variaveis apos erro
                                else if (numeroChutado > numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é maior que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //vitoria
                                else if (numeroChutado == numeroSecreto)
                                {
                                    Console.WriteLine($"Você acertou o numero era {numeroSecreto} ");
                                    Console.WriteLine($"A sua pontuação foi {pontuacao}");
                                    Console.ReadLine();
                                    break;
                                }


                            }
                            break;
                        case 2:
                            //REPETICAO BASEADO TENTATIVAS E DIFICULDADE
                            for (tentativa = 10; tentativa > 0; tentativa--)
                            {
                                Console.WriteLine($"Tentativa {tentativaAtual} de 10");
                                Console.WriteLine($"Pontuacao atual = {pontuacao}");
                                Console.WriteLine();
                                Console.WriteLine($"qual a sua {tentativaAtual} tentativa ?");
                                int numeroChutado = int.Parse(Console.ReadLine());

                                //incremento variaveis apos erro
                                if (numeroChutado < numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é menor que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //incremento variaveis apos erro
                                else if (numeroChutado > numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é maior que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //vitoria
                                else if (numeroChutado == numeroSecreto)
                                {
                                    Console.WriteLine($"Você acertou o numero era {numeroSecreto} ");
                                    Console.WriteLine($"A sua pontuação foi {pontuacao}");
                                    Console.ReadLine();
                                    break;
                                }


                            }
                            break;
                        case 3:
                            //REPETICAO BASEADO TENTATIVAS E DIFICULDADE
                            for (tentativa = 5; tentativa > 0; tentativa--)

                            {
                                Console.WriteLine($"Tentativa {tentativaAtual} de 5");
                                Console.WriteLine($"Pontuacao atual = {pontuacao}");
                                Console.WriteLine();
                                Console.WriteLine($"qual a sua {tentativaAtual} tentativa ?");
                                int numeroChutado = int.Parse(Console.ReadLine());

                                //incremento variaveis apos erro
                                if (numeroChutado < numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é menor que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //incremento variaveis apos erro
                                else if (numeroChutado > numeroSecreto)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"O numero chutado é maior que o numero Secreto");
                                    int subtracao = Math.Abs((numeroChutado - numeroSecreto) / 2);
                                    pontuacao = pontuacao - subtracao;
                                    tentativaAtual++;
                                }
                                //vitoria
                                else if (numeroChutado == numeroSecreto)
                                {
                                    Console.WriteLine($"Você acertou o numero era {numeroSecreto} ");
                                    Console.WriteLine($"A sua pontuação foi {pontuacao}");
                                    Console.ReadLine();
                                    break;
                                }



                            }
                            break;

                    }

                    if (tentativa == 0)
                    {
                        Console.WriteLine($"VocÊ perdeu o numero era {numeroSecreto}");
                        Console.ReadLine();

                    }
                }
                Console.WriteLine("deseja tentar novamente ? S/N");
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();
            } 


        }
    }
}
