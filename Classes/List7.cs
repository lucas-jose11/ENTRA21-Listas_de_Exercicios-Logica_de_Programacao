using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTRA21_Listas_de_Exercícios_Lógica_de_Programação.Classes
{
    public class List7
    {
        using System.Diagnostics;

namespace Lista07Exercicios
    {
        public class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    int respostaUsuario;
                    do
                    {
                        Console.WriteLine("Exercícios de Matrizes.");
                        Console.WriteLine("Escolha qual você quer ver:");
                        Console.WriteLine("[1] Criando uma Matriz - Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos." +
                            "\n[2] Soma dos Elementos - Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos." +
                            "\n[3] Maior e Menor Valor - Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz." +
                            "\n[4] Diagonal Principal - Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada." +
                            "\n[5] Transposta de uma Matriz - Implemente um programa que gere a transposta de uma matriz 3x3." +
                            "\n[6] Matriz Identidade - Construa um programa que verifica se uma matriz quadrada é uma matriz identidade." +
                            "\n[7] Multiplicação de Matrizes - Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado." +
                            "\n[8] Média dos Elementos - Calcule a média dos valores armazenados em uma matriz 4x4." +
                            "\n[9] Matriz Esparsa - Desenvolva um programa que verifica se uma matriz possui mais elementos nulos (0) do que não nulos." +
                            "\n[10] Matriz Dinâmica - Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela." +
                            "\n[0] PARA SAIR.");

                        bool entradaValida = false;
                        respostaUsuario = -1;

                        while (!entradaValida)
                        {
                            string entrada = Console.ReadLine();

                            if (int.TryParse(entrada, out respostaUsuario))
                            {
                                if (respostaUsuario >= 0 && respostaUsuario <= 10)
                                {
                                    entradaValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida. Por favor, digite uma opção válida.\n----------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, digite apenas números.\n----------------------------");
                            }
                        }

                        Console.Clear();
                        switch (respostaUsuario)
                        {
                            case 1:
                                Exercicio1();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Exercicio2();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 3:
                                Exercicio3();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 4:
                                Exercicio4();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 5:
                                Exercicio5();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 6:
                                Exercicio6();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 7:
                                Exercicio7();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 8:
                                Exercicio8();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 9:
                                Exercicio9();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 10:
                                Exercicio10();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 0:
                                Console.WriteLine("Saindo...");
                                break;

                            default:
                                Console.WriteLine("Opção inválida.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }

                    } while (respostaUsuario != 0);

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Tentou dividir por 0.");
                }
                catch (FormatException tipo)
                {
                    Console.WriteLine($"Entrada de tipo inválida. {tipo.Message}.");
                }
                catch (System.OutOfMemoryException)
                {
                    Console.WriteLine("Não tem memória suficiente para continuar a execução.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}.");
                }
            }


            static void Exercicio1()
            {
                Console.WriteLine("[1] Criando uma Matriz - Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos.");
                Console.WriteLine("----------------------");
                int[,] matriz = {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
                Console.WriteLine(PrintarMatriz(matriz));
            }

            static void Exercicio2()
            {
                Console.WriteLine("[2] Soma dos Elementos - Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos.");
                Console.WriteLine("----------------------");
                int[,] matrizSomaElementos = {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };

                int somaDosElementos = 0;
                for (int i = 0; i < matrizSomaElementos.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizSomaElementos.GetLength(1); j++)
                    {
                        Console.Write(matrizSomaElementos[i, j] + " ");
                        somaDosElementos += matrizSomaElementos[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"A soma dos elementos dessa matriz é {somaDosElementos}.");
            }

            static void Exercicio3()
            {
                Console.WriteLine("[3] Maior e Menor Valor - Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz.");
                Console.WriteLine("----------------------");
                int[,] matrizMenorMaiorElemento = {
                { 5, 1, 0},
                { 23, 50, 4},
                { 71, -8, 4}
            };

                int menorDaMatriz = matrizMenorMaiorElemento[0, 0];
                int maiorDaMatriz = matrizMenorMaiorElemento[0, 0];
                for (int i = 0; i < matrizMenorMaiorElemento.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizMenorMaiorElemento.GetLength(1); j++)
                    {
                        Console.Write(matrizMenorMaiorElemento[i, j] + " ");

                        if (matrizMenorMaiorElemento[i, j] < menorDaMatriz)
                        {
                            menorDaMatriz = matrizMenorMaiorElemento[i, j];
                        }
                        if (matrizMenorMaiorElemento[i, j] > maiorDaMatriz)
                        {
                            maiorDaMatriz = matrizMenorMaiorElemento[i, j];
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"-----------------------\nDa matriz acima, o menor elemento é {menorDaMatriz} e o maior elemento é {maiorDaMatriz}.");
            }

            static void Exercicio4()
            {
                Console.WriteLine("[4] Diagonal Principal - Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada.");
                Console.WriteLine("----------------------");
                int[,] matrizDiagonalPrincipal =
                {
                { 79, 32, 10},
                { 11, 32, 23},
                { 30, 23, -12}
            };

                Console.WriteLine("Temos a matriz a seguir:");
                Console.WriteLine(PrintarMatriz(matrizDiagonalPrincipal));

                Console.WriteLine("-------------------\nMostrando apenas a diagonal principal, ela fica assim:");
                for (int i = 0; i < matrizDiagonalPrincipal.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizDiagonalPrincipal.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.Write(matrizDiagonalPrincipal[i, j]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            static void Exercicio5()
            {
                Console.WriteLine("[5] Transposta de uma Matriz - Implemente um programa que gere a transposta de uma matriz 3x3.");
                Console.WriteLine("----------------------");
                int[,] matrizParaTransportar =
                {
                { 11, 12, 13},
                { 21, 22, 23},
                { 31, 32, 33}
            };

                int[,] matrizTransporta = GerarTransposta(matrizParaTransportar);

                Console.WriteLine("Temos essa matriz:");
                Console.WriteLine(PrintarMatriz(matrizParaTransportar));

                Console.WriteLine("---------------------\nEla transporta fica assim:");
                Console.WriteLine(PrintarMatriz(matrizTransporta));
            }

            static void Exercicio6()
            {
                Console.WriteLine("[6] Matriz Identidade - Construa um programa que verifica se uma matriz quadrada é uma matriz identidade.");
                Console.WriteLine("----------------------");
                int[,] matrizIsIdentidade =
                {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 2, 0, 1 }
            };

                Console.WriteLine("Temos essa matriz:");
                Console.Write(PrintarMatriz(matrizIsIdentidade));

                if (LinhasDeUmaMatriz(matrizIsIdentidade) != ColunasDeUmaMatriz(matrizIsIdentidade))
                {
                    Console.WriteLine("Essa matriz não é quadrada. Por isso não tem diagonal principal completa.");
                }
                else if (MatrizEhIdentidade(matrizIsIdentidade) == true)
                {
                    Console.WriteLine("Essa matriz é quadrada e também é uma Matriz Identidade.");
                }
                else if (MatrizEhQuadrada(matrizIsIdentidade) == true)
                {
                    Console.WriteLine("Essa matriz é quadrada, mas não é uma Matriz Identidade.");
                }
            }

            static void Exercicio7()
            {
                Console.WriteLine("[7] Multiplicação de Matrizes - Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado.");
                Console.WriteLine("----------------------");
                int[,] matrizUm =
                {
                { 3, 5 },
                { 1, 2 },
            };

                int[,] matrizDois =
                {
                { 2, -5 },
                { -1, 3 },
            };

                Console.WriteLine("Temos duas matrizes, a Matriz A:");
                Console.WriteLine(PrintarMatriz(matrizUm));
                Console.WriteLine("----------\nE a Matriz B:");
                Console.WriteLine(PrintarMatriz(matrizDois));
                Console.WriteLine("----------");

                int[,] matrizTres = MultiplicarMatrizesDeDois(matrizUm, matrizDois);

                Console.WriteLine($"E a Matriz C, que é a Matriz A vezes a Matriz B é assim:\n{PrintarMatriz(matrizTres)}");
            }

            static void Exercicio8()
            {
                Console.WriteLine("[8] Média dos Elementos - Calcule a média dos valores armazenados em uma matriz 4x4.");
                Console.WriteLine("----------------------");
                int[,] matrizMediaElementos =
                {
                { 1, 0, 1, 9 },
                { 1, 0, 1, 3 },
                { 1, 7, 1, 3 },
                { 1, 0, 2, 3 }
            };

                Console.WriteLine("Temos essa matriz abaixo.");
                PrintarMatriz(matrizMediaElementos);

                double somaDosElementos = 0;
                for (int i = 0; i < matrizMediaElementos.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizMediaElementos.GetLength(1); j++)
                    {
                        Console.Write(matrizMediaElementos[i, j] + " ");
                        somaDosElementos += matrizMediaElementos[i, j];
                    }
                    Console.WriteLine();
                }
                double resultadoMediaElementos = somaDosElementos / (LinhasDeUmaMatriz(matrizMediaElementos) * ColunasDeUmaMatriz(matrizMediaElementos));

                Console.WriteLine($"--------------------\nA média de seus " +
                    $"{LinhasDeUmaMatriz(matrizMediaElementos) + ColunasDeUmaMatriz(matrizMediaElementos)} elementos é {resultadoMediaElementos}.");
            }

            static void Exercicio9()
            {
                Console.WriteLine("[9] Matriz Esparsa - Desenvolva um programa que verifica se uma matriz possui mais elementos nulos (0) do que não nulos.");
                int[,] matrizQuaseNula =
                {
                { 0, 0, 1, 9 },
                { 3, 0, -1, 0 },
                { 0, 7, 1, 0 },
                { 2, 0, 0, 0 }
            };
                Console.WriteLine("Temos essa matriz aqui:");
                Console.WriteLine(PrintarMatriz(matrizQuaseNula));
                Console.WriteLine($"Essa matriz {(MatrizEhMaioriaNula(matrizQuaseNula) ? "tem" : "não tem")} mais elementos nulos que elementos não nulos.");
            }

            static void Exercicio10()
            {
                Console.WriteLine("[10] Matriz Dinâmica - Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela.");
                Console.WriteLine("----------------------");
                int[,] matriz = UsuarioInsereValores();

                Console.WriteLine("--------------------------\nEssa é a sua matriz:");
                Console.WriteLine(PrintarMatriz(matriz));
            }


            static string PrintarMatriz(int[,] matriz)
            {
                string resultado = "";

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        resultado += matriz[i, j] + " ";
                    }
                    resultado += "\n";
                }
                return resultado;
            }

            static int LinhasDeUmaMatriz(int[,] matriz)
            {
                int auxLinhas = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    auxLinhas++;
                }
                return auxLinhas;
            }

            static int ColunasDeUmaMatriz(int[,] matriz)
            {
                int auxColunas = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    auxColunas++;
                }
                return auxColunas;
            }

            static bool MatrizEhQuadrada(int[,] matriz)
            {
                if (LinhasDeUmaMatriz(matriz) == ColunasDeUmaMatriz(matriz))
                {
                    return true;
                }
                return false;
            }

            static int[,] GerarTransposta(int[,] matriz)
            {
                int[,] transposta = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        transposta[j, i] = matriz[i, j]; // Troca linhas por colunas
                    }
                }
                return transposta;
            }

            static bool MatrizEhIdentidade(int[,] matriz)
            {

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(0); j++)
                    {
                        if (i == j)
                        {
                            if (matriz[i, j] != 1)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (matriz[i, j] != 0)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }

            static int[,] MultiplicarMatrizesDeDois(int[,] matrizUm, int[,] matrizDois)
            {
                int[,] matrizTresMultiplicada = new int[2, 2];

                for (int i = 0; i < matrizUm.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizDois.GetLength(1); j++)
                    {
                        matrizTresMultiplicada[i, j] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            matrizTresMultiplicada[i, j] += matrizUm[i, k] * matrizDois[k, j];
                        }
                    }
                }
                return matrizTresMultiplicada;
            }

            static bool MatrizEhMaioriaNula(int[,] matriz)
            {
                int contaZeros = 0;
                int contaNaoZeros = 0;

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == 0)
                        {
                            contaZeros++;
                        }
                        else
                        {
                            contaNaoZeros++;
                        }
                    }
                }
                if (contaZeros > contaNaoZeros)
                {
                    return true;
                }
                else { return false; }
            }

            static int[,] UsuarioInsereValores()
            {
                Console.WriteLine("Ajude-me a fazer uma matriz, quantas linhas ela vai ter?");
                int linhasMatriz = int.Parse(Console.ReadLine());

                Console.WriteLine("E quantas colunas ela vai ter?");
                int colunasMatriz = int.Parse(Console.ReadLine());

                int[,] matrizVariavelDoUsuario = new int[linhasMatriz, colunasMatriz];

                for (int i = 0; i < matrizVariavelDoUsuario.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizVariavelDoUsuario.GetLength(1); j++)
                    {
                        Console.WriteLine($"Escreva o elemento [{i},{j}].");
                        matrizVariavelDoUsuario[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine("---");
                    }
                }
                return matrizVariavelDoUsuario;
            }
        }
    }
}
}
