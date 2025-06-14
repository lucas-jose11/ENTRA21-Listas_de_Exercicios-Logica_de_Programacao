using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTRA21_Listas_de_Exercícios_Lógica_de_Programação.Classes
{
    public class List4
    {

        int auxiliarSessoes = 1;

while (auxiliarSessoes != 0)
{
    int auxiliarGeral = 1;
        Console.WriteLine("Escolha a Sessão de Exercício.\n1 para Exercícios de While e 2 para Exercícios de Do-While e 3 para sair");
    auxiliarGeral = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------");
    Console.Clear();

    if (auxiliarGeral == 1)
    {
        int auxiliarWhile = 0;
        while (auxiliarWhile != 6)
        {
            Console.WriteLine("Digite o exercício que deseja ver (1~5).\n1- Contagem Crescente\n2- Adivinhe o número\n3- Calculadora Simples\n4- Soma de Números\n5- Fatorial\n6- Voltar para págna anterior");
            auxiliarWhile = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------");
            Console.Clear();
            switch (auxiliarWhile)
            {
                case 1:
                    Console.WriteLine("Exercício 1: Contagem Crescente.\nEscreva um programa que utilize um loop while para exibir os números de 1 a 10 em ordem crescente.");
                    Console.WriteLine("----------------------");
                    int num1 = 1;
                    while (num1 <= 10)
                    {
                        Console.WriteLine(num1);
                        num1++;
                    }
    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Exercício 2: Adivinhe o Número.\nCrie um jogo em que o computador gera um número aleatório entre 1 e 100, e o jogador deve adivinhar qual é esse número. Use um loop while para permitir que o jogador faça múltiplas tentativas até acertar. Caso ele digite zero o jogo deve se encerrar.");
                    Console.WriteLine("Tente acertar o número entre 1 e 100!\nDigite 0 para parar o jogo.");
                    Console.WriteLine("----------------------");
                    bool sairdojogo = false;
    Random aleatorioRandom = new Random();
    int aleatorioNumber = aleatorioRandom.Next(1, 100); // entre 1 e 100
                    while (sairdojogo == false)
                    {
                        Console.WriteLine("Digite o número que você acha que é o certo.");
                        int numChutado = int.Parse(Console.ReadLine());
                        if (numChutado == 0)
                        {
                            Console.WriteLine("Você não conseguiu acertar!");
                            Console.WriteLine(" ");
                            Console.WriteLine("Saindo do jogo.");
                            sairdojogo = true;
                            break;
                        }
if (numChutado != aleatorioNumber && numChutado != 0)
{
    Console.WriteLine("Você errou!");
}
else Console.WriteLine("Você acertou o número!");
                    }
                    Console.ReadLine();
Console.Clear();
break;

                case 3:
    Console.WriteLine("Exercício 3: Calculadora Simples.\nImplemente uma calculadora simples que pede ao usuário para inserir dois números e uma operação (+, -, *, /). Use um loop while para permitir que o usuário realize cálculos repetidamente até optar por sair digitando q na operação desejada.");
    Console.WriteLine("Que operação realizar?\n1 para adição.\n2 para subtração.\n3 para multiplicação.\n4 para divisão.\n5 para sair.");
    Console.WriteLine("----------------------");
    int respostaOperaçãoCalculadora = int.Parse(Console.ReadLine());
    double numCalcular1, numCalcular2 = 0;

    bool calculadoraAtiva = true;
    while (calculadoraAtiva == true)
    {
        switch (respostaOperaçãoCalculadora)
        {
            case 1:
                Console.WriteLine("Digite seu primeiro número");
                numCalcular1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número número");
                numCalcular2 = double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.Write($"Resposta da Operação: {numCalcular1 + numCalcular2}");
                calculadoraAtiva = false;
                break;

            case 2:
                Console.WriteLine("Digite seu primeiro número");
                numCalcular1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número número");
                numCalcular2 = double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.Write($"Resposta da Operação: {numCalcular1 - numCalcular2}");
                calculadoraAtiva = false;
                break;

            case 3:
                Console.WriteLine("Digite seu primeiro número");
                numCalcular1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número número");
                numCalcular2 = double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.Write($"Resposta da Operação: {numCalcular1 * numCalcular2}");
                calculadoraAtiva = false;
                break;

            case 4:
                Console.WriteLine("Digite seu primeiro número");
                numCalcular1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número número");
                numCalcular2 = double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");
                Console.Write($"Resposta da Operação: {numCalcular1 / numCalcular2}");
                calculadoraAtiva = false;
                break;

            case 5:
                Console.WriteLine("Saindo da calculadora...");
                calculadoraAtiva = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;

        }
        Console.ReadLine();
        Console.Clear();
    }
    break;

case 4:
    Console.WriteLine("Exercício 4: Soma de Números.\nPeça ao usuário para inserir uma série de números positivos. Use um loop while para continuar lendo números até que o usuário insira um número negativo. Em seguida, exiba a soma dos números positivos inseridos.");
    Console.WriteLine("----------------------");
    double num4 = 1;
    double somaTotal = 0;

    while (num4 >= 0)
    {
        Console.WriteLine("Código funcionando");
        Console.WriteLine("Escreva um número");
        num4 = double.TryParse(Console.ReadLine(), out double Num4) ? Num4 : 0; //tratameto de exceção, Num4 : 0 pra atribuir oq eu escreve no num4 e não atribuir onum4 pra ele msm
        somaTotal += Num4;

        if (num4 < 0)
        {
            Console.WriteLine("Código parando...");
            Console.WriteLine(" ");
            somaTotal -= Num4;
        }
    }
    Console.WriteLine($"A soma total dos números, de acordo com as regras, foi: {somaTotal}");
    Console.ReadLine();
    Console.Clear();
    break;

case 5:
    Console.WriteLine("Exercício 5: Fatorial.\nSolicite um número inteiro positivo do usuário e calcule o fatorial desse número usando um loop while. Exiba o resultado no final.");
    Console.WriteLine("----------------------");
    Console.WriteLine("Digite um número inteiro para descobrir o seu fatorial.");
    int paraFatoriar = int.TryParse(Console.ReadLine(), out int ParaFatoriar) ? ParaFatoriar : 0;

    if (paraFatoriar == 0) Console.WriteLine("O fatorial de 0 é 1.");
    if (paraFatoriar < 0) Console.WriteLine("Escreva um número inteiro positivo.");

    int resultadoFatorial = paraFatoriar;
    int auxFatorial = paraFatoriar - 1;
    while (auxFatorial > 0)
    {
        resultadoFatorial = resultadoFatorial *= auxFatorial;
        auxFatorial -= 1;
    }
    Console.WriteLine($"O fatorial de {paraFatoriar} é {resultadoFatorial}.");
    Console.ReadLine();
    Console.Clear();
    break;
}
        }
    }

    else if (auxiliarGeral == 2)
{
    int auxiliarDoWhile = 0;
    while (auxiliarDoWhile != 6)
    {
        Console.WriteLine("Digite o exercício que deseja ver (1~5).\n1- Tabela de Multiplicação\n2- Média de Notas\n3- Contagem Regressiva\n4- Soma dos Dígitos\n5- Adivinhe o Número\n6- Voltar para págna anterior");
        auxiliarDoWhile = int.Parse(Console.ReadLine());
        Console.WriteLine("----------------");
        Console.Clear();

        switch (auxiliarDoWhile)
        {
            case 1:
                Console.WriteLine("Exercício 1: Tabela de Multiplicação.\nEscreva um programa que solicite ao usuário um número inteiro. O programa deve então imprimir a tabela de multiplicação desse número, exibindo os produtos do número pelo contador de 1 a 10.");
                Console.WriteLine("----------------");
                Console.WriteLine("Escreva um número para ser exibida sua tabuada.");
                double numPraTabuar = double.TryParse(Console.ReadLine(), out double NumPraTabuar) ? NumPraTabuar : 0;

                int auxTabuar = 1;
                do
                {
                    Console.WriteLine($"{numPraTabuar} x {auxTabuar} = {numPraTabuar * auxTabuar}");
                    auxTabuar++;
                } while (auxTabuar <= 10);

                Console.ReadLine();
                Console.Clear();
                break;

            case 2:
                Console.WriteLine("Exercício 2: Média de Notas.\nDesenvolva um programa que permita ao usuário inserir uma série de notas. O programa deve calcular e exibir a média das notas inseridas, desconsiderando notas negativas. A entrada de notas deve continuar até que o usuário insira o valor -1, indicando o final da entrada.");
                Console.WriteLine("----------------");
                double nota = 0;
                double somaNotas = 0;
                int quantidadeNotas = 0;

                do
                {
                    Console.WriteLine("Insira uma nota ou aperte -1 para terminar a adição de notas e mostrar a média");
                    nota = double.Parse(Console.ReadLine());
                    somaNotas += nota;
                    quantidadeNotas++;
                    if (nota == -1)
                    {
                        quantidadeNotas--;
                        somaNotas -= nota;
                    }

                } while (nota != -1);

                double mediaNotas = somaNotas / quantidadeNotas;
                Console.WriteLine($"A média das {quantidadeNotas} foi: {mediaNotas}");
                Console.ReadLine();
                Console.Clear();
                break;

            case 3:
                Console.WriteLine("Exercício 3: Contagem Regressiva.\nEscreva um programa que solicite ao usuário um número inteiro positivo e, em seguida, realize uma contagem regressiva a partir desse número até zero.");
                Console.WriteLine("----------------");
                Console.WriteLine("Escreva um número inteiro");
                int numContRegressiva = int.Parse(Console.ReadLine());
                int auxContRegress = 0;
                Console.WriteLine("---------------\nEstá aqui a contagem regressiva:\n---------------");
                do
                {
                    Console.WriteLine(numContRegressiva - auxContRegress);
                    auxContRegress++;
                } while (auxContRegress <= numContRegressiva);

                Console.ReadLine();
                Console.Clear();
                break;

            case 4:
                Console.WriteLine("Exercício 4: Soma dos Dígitos.\nEscreva um programa que solicite ao usuário um número inteiro e calcule a soma de seus dígitos.Escreva um programa que solicite ao usuário um número inteiro e calcule a soma de seus dígitos.");
                Console.WriteLine("----------------");
                Console.WriteLine("Escreva um inteiro.");
                int numPraDividir = int.Parse(Console.ReadLine());
                int auxnum9 = 0;
                int aux9 = numPraDividir;
                do
                {
                    auxnum9 += numPraDividir % 10;
                    numPraDividir /= 10;

                } while (numPraDividir != 0);

                Console.WriteLine($"A soma dos dítitos de {aux9} é {auxnum9}.");
                Console.ReadLine();
                Console.Clear();

                break;



            case 5:
                Console.WriteLine("Exercício 5: Adivinhe o Número.\nO usuário deve inserir sua suposição, e o programa deve informar se o palpite está muito alto, muito baixo ou correto.O programa deve continuar solicitando palpites até que o usuário adivinhe o número correto.");
                Console.WriteLine("----------------");
                Console.WriteLine("Tente acertar o número entre 1 e 100!\nDigite 0 para parar o jogo.");

                bool sairdojogo10 = false;
                Random aleatorioRandom10 = new Random();
                int aleatorioNumber10 = aleatorioRandom10.Next(1, 100); // entre 1 e 100

                while (sairdojogo10 == false)
                {
                    Console.WriteLine("Digite o número que você acha que é o certo.");
                    int numChutado10 = int.Parse(Console.ReadLine());

                    if (numChutado10 == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Saindo do jogo...");
                        sairdojogo10 = true;
                        break;
                    }

                    if (numChutado10 != aleatorioNumber10)
                    {
                        if (numChutado10 > aleatorioNumber10)
                        {
                            Console.WriteLine("Seu palpite está muito alto!");
                        }
                        else
                        {
                            Console.WriteLine("Seu palpite está muito baixo!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você acertou o número! Parabéns!\nSaindo do jogo...");
                        sairdojogo10 = true;
                    }
                }
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }
}

else if (auxiliarGeral == 3)
{
    Console.WriteLine("Saindo...");
    auxiliarSessoes = 0;
}

else
{
    Console.WriteLine("Opção inválida. Tente novamente\n-------------------------------");
}
}
// consegui fazer o "desafio" professor :D
    }
}
