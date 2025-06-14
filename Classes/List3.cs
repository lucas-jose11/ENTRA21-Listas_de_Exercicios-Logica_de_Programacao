using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTRA21_Listas_de_Exercícios_Lógica_de_Programação.Classes
{
    public class List3
    {
        Console.WriteLine("Escolha qual exercício deseja ver (1~13).");
string selecao = Console.ReadLine();
        Console.WriteLine(" ");
Console.WriteLine($"Exercício {selecao}");

switch (selecao)
{
    //Exercício 1: Imprimir números de 1 a 10:
    case "1":
        for (int i = 1; i <= 10; i += 1)
        {
            Console.WriteLine(i);
        }
    break;


    //Exercício 2: Calcular a soma dos primeiros 100 números inteiros:
    //Desenvolva um programa em C# que calcule e exiba a soma dos primeiros 100 números inteiros usando um loop for.
    case "2":
        int somaTodos = 0;
        for (int i = 1; i <= 100; i += 1)
        {
            Console.WriteLine($"{somaTodos + i}");
            somaTodos += i; 
        }
break;


    //Exercício 3: Imprimir os números pares de 1 a 20:
    //Crie um programa em C# que utilize um loop for para imprimir os números pares no intervalo de 1 a 20.
    case "3":
    for (int i = 0; i <= 20; i += 2)
    {
        Console.WriteLine(i);
    }
    break;


//Exercício 4: Calcular o fatorial de um número dado:
//Elabore um programa em C# que calcule e apresente o fatorial de um número inteiro fornecido pelo usuário usando um loop for.
case "4":
    Console.WriteLine("Escreva um número inteiro.");
    int numPraFatoriar = int.Parse(Console.ReadLine());
    for (int i = numPraFatoriar - 1; i >= 1; i--)
    {
        Console.Write($"{numPraFatoriar} * {i} = ");
        numPraFatoriar = numPraFatoriar * i;
        Console.WriteLine(numPraFatoriar);
    }
    break;


//Exercício 5: Imprimir a tabuada de multiplicação de um número dado:
//Descreva um programa em C# que exiba a tabuada de multiplicação de um número inteiro fornecido pelo usuário, usando um loop for para calcular os resultados.
case "5":
    Console.WriteLine("Escreva um número inteiro.");
    int numPraTabuar = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.Write($"{numPraTabuar} * {i} = ");
        Console.WriteLine(numPraTabuar * i);
    }
    break;


//Exercício 6: Contar a quantidade de números pares e ímpares em um intervalo:
//Crie um programa em C# que conte e mostre a quantidade de números pares e ímpares no intervalo de 1 a 100, usando um loop for.
case "6":
    int numsPares = 0, numsImpares = 0;
    for (int i = 1; i <= 100; i += 1)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i} é par");
            numsPares++;
        }
        else
        {
            Console.WriteLine($"{i} é ímpar");
            numsImpares++;
        }
    }
    Console.WriteLine($"Números pares: {numsPares} \nNúmeros ímpares: {numsImpares} ");
    break;


//Exercício 7: Calcular a média de um conjunto de notas:
//Desenvolva um programa em C# que calcule a média de um conjunto de notas e exiba o resultado.
case "7":
    double notasAluno = 0;
    double mediaFinal = 0;
    Console.WriteLine("Escreva as notas do aluno");
    for (int i = 1; i <= 3; i += 1)
    {
        Console.Write($"{i}- ");
        notasAluno = double.Parse(Console.ReadLine());
        mediaFinal += notasAluno;
    }
    Console.WriteLine($"A média do aluno {(mediaFinal / 3):0.##}.");
    break;


//Exercício 8: Imprimir os primeiros 20 termos da sequência de Fibonacci:
//Escreva um programa em C# que utilize um loop for para calcular e imprimir os primeiros 20 termos da sequência de Fibonacci.
case "8":
    int termo1 = 0;
    Console.WriteLine(termo1);
    int termo2 = 1;
    Console.WriteLine(termo2);

    for (int i = 0; i < 18; i++)
    {
        int proximo = termo1 + termo2;
        Console.WriteLine(proximo);

        termo1 = termo2;
        termo2 = proximo;
    }
    break;


//Exercício 9: Verificar se um número é primo:
//Crie um programa em C# que verifique se um número inteiro fornecido pelo usuário é primo ou não, utilizando um loop for para realizar a verificação.
case "9":

    Console.WriteLine("Digite um numero");
    int n = Convert.ToInt32(Console.ReadLine());
    bool primo = true;

    for (int i = n - 1; i > 1; i--)
    {
        if (n % i == 0) primo = false;
    }

    Console.WriteLine(primo ? "Primo" : "Não é primo");
    break;


//Exercício 10: Criar um padrão de triângulo utilizando asteriscos:
//Elabore um programa em C# que utilize loops for aninhados para criar e exibir um padrão de triângulo formado por asteriscos.
case "10":
    Console.WriteLine("Digite a quatidade de linhas do triângulo retângulo.");
    int linhas = int.Parse(Console.ReadLine());

    for (int i = 1; i <= linhas; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    break;


//Exercício 11: Soma de Números Pares
//Escreva um programa que calcule e exiba a soma dos números pares de 1 a 100 utilizando um loop for.
case "11":
    int somaTodosPares = 0;
    for (int i = 1; i <= 100; i += 1)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{somaTodosPares + i}");
            somaTodosPares += i;
        }
    }
    break;


//Exercício 12: Sequência de Potências
//Crie um programa que peça ao usuário para inserir um número inteiro e, em seguida, exiba a sequência de potências de 2 até a potência correspondente ao número inserido.
case "12":
    Console.WriteLine("Digite o número");
    int num = int.TryParse(Console.ReadLine(), out int Num) ? Num : 1;
    for (int i = 1; i <= num; i++)
    {
        int valor = 1;
        for (int j = 1; j <= i; j++)
        {
            valor = valor * 2;
        }
        Console.WriteLine($"2^{i} = {valor}");
    }
    break;


//Exercício 13: Contagem Regressiva
//Peça ao usuário para inserir um número inteiro positivo e utilize um loop for para fazer uma contagem regressiva a partir desse número até 1, exibindo cada valor.
case "13":
    Console.WriteLine("Escreva um número inteiro.");
    int numContaRegressiva = int.Parse(Console.ReadLine());
    for (int i = numContaRegressiva; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
    break;
}
    }
}
