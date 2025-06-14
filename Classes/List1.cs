using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTRA21_Listas_de_Exercícios_Lógica_de_Programação.Classes
{
    public class List1
    {
        
        static void Exercise1()
        {
            Console.WriteLine("Primeiro Exercício: Declare uma variável do tipo int, atribua um valor e imprima na tela.");
            int numero = 10;
            Console.Write(numero);
        }

        static void Exercise2()
        {
            Console.WriteLine("Segundo Exercício: Crie uma variável string com o nome do seu curso e exiba a mensagem: “Bem - vindo ao curso[nome]");
            string nomeCurso = "C#";
            Console.Write($"Bem-vindo ao curso " + nomeCurso);
        }
        
        static void Exercise3()
        {
            Console.WriteLine("Terceiro Exercício: Declare duas variáveis do tipo double, atribua valores e exiba a soma.");
            double decimalA = 5.3;
            double decimalB = 6.7;
            Console.WriteLine(decimalA + decimalB);
        }

        static void Exercise4()
        {
            Console.WriteLine("Quarto Exercício: Leia um número inteiro do usuário e exiba o quadrado desse número.");
            Console.WriteLine("Qual é o seu número favorito?");
            int numeroFavorito = int.Parse(Console.ReadLine());
            int numeroFavoritoAoQuadrado = numeroFavorito * numeroFavorito;
            Console.WriteLine(numeroFavoritoAoQuadrado);
        }

        static void Exercise5()
        {
            //Quinto Exercício: Verifique se um número inteiro lido do teclado é par ou ímpar.
            Console.WriteLine("Qual é o seu número?");
            int numeroParOuImpar = int.Parse(Console.ReadLine());
            int numeroParOuImparRestoDivisao = numeroParOuImpar % 2;
            Console.WriteLine("O seu número é par?");
            Console.WriteLine(numeroParOuImparRestoDivisao == 0);
        }

        static void Exercise6()
        {

            //Sexto Exercício: Leia dois números inteiros e exiba o maior deles.
            Console.WriteLine("Qual seu primeiro número?");
            int numeroComparação1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu segundo número?");
            int numeroComparação2 = int.Parse(Console.ReadLine());
            if (numeroComparação1 > numeroComparação2)
                Console.WriteLine($"O número maior é o " + numeroComparação1);
            else Console.WriteLine($"O número maior é o " + numeroComparação2);

        }

        static void Exercise7()
        {
            //Sétimo Exercício: Crie uma variável booleana que indica se a soma de dois números é maior que 100.
            Console.WriteLine("Qual seu primeiro número?");
            int numeroSoma100Um = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu segundo número?");
            int numeroSoma100Dois = int.Parse(Console.ReadLine());
            int numeroSoma100UmMaisDois = numeroSoma100Um + numeroSoma100Dois;
            Console.WriteLine($"O número " + numeroSoma100UmMaisDois + " é maior que 100?");
            Console.Write(numeroSoma100UmMaisDois > 100);

        }

        static void Exercise8()
        {
            //Oitavo Exercício: Converta uma variável double para int e exiba o valor antes e depois da conversão.
            double numeroConversao = 15.5;
            Console.WriteLine($"O número é {numeroConversao}");
            int numeroDepoisConversao = Convert.ToInt32(numeroConversao);
            Console.WriteLine($"Antes da conversão, era {numeroConversao}, depois da conversão, é {numeroDepoisConversao}");

        }

        static void Exercise9()
        {

            //Nono Exercício: Declare uma variável e calcule a variável ao cubo.
            Console.WriteLine("Qual é o seu número favorito?");
            int numeroFavorito9 = int.Parse(Console.ReadLine());
            int numeroFavoritoAoCubo = numeroFavorito9 * numeroFavorito9 * numeroFavorito9; Console.WriteLine(numeroFavoritoAoCubo);
        }

        static void Exercise10()
        {
            //Décimo Exercício: Crie uma expressão que verifica se um número é múltiplo de 5 e de 3 ao mesmo tempo.
            Console.WriteLine("Qual é o seu número?");
            int numeroTresCinco = int.Parse(Console.ReadLine());
            Console.WriteLine("O número é divisível por 3 e 5?");
            Console.WriteLine(numeroTresCinco % 3 == 0 && numeroTresCinco % 5 == 0);
        }

        static void Exercise11()
        {


            //Décimo Primeiro Exercício: Leia uma idade e exiba uma mensagem informando se é maior de idade.
            Console.WriteLine("Quantos anos você tem?");
            int numeroIdade = int.Parse(Console.ReadLine());
            if (numeroIdade >= 18)
                Console.WriteLine("Você é maior de idade no Brasil");
            else Console.WriteLine("Você não é maior de idade no Brasil");


        }

        static void Exercise12()
        {

            //Décimo Segundo Exercício: Leia um valor em graus Celsius e converta para Fahrenheit.
            Console.WriteLine("Quantos graus Celsius está?");
            double numeroTemp = Convert.ToDouble(Console.ReadLine());
            double numeroTempF = (numeroTemp * 9 / 5) + 32;
            Console.WriteLine($"A temperatura está {numeroTempF} em graus Fahrenheit");
        }

        static void Exercise13()
        {

            //Décimo Terceiro Exercício: Crie um programa que recebe três números e exibe a média aritmética.
            Console.WriteLine("Qual é o primeiro número? Números com casas decimais favor colocar '.' ao invés de ','.");
            double numeroSomaUm = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o segundo número? Números com casas decimais favor colocar '.' ao invés de ','.");
            double numeroSomaDois = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o terceiro número? Números com casas decimais favor colocar '.' ao invés de ','.");
            double numeroSomaTres = double.Parse(Console.ReadLine());
            double numeroMediaDosTres = (numeroSomaUm + numeroSomaDois + numeroSomaTres) / 3;
            Console.WriteLine($"A média aritmética dentre os 3 números que você escreveu é {numeroMediaDosTres.ToString("F3")}");
        }

        static void Exercise14()
        {
            //Décimo Quarto Exercício: Declare uma variável que representa um salário e calcule um aumento de 10%.
            Console.WriteLine("Qual o seu salário atual?");
            double numeroSalário = Convert.ToDouble(Console.ReadLine());
            double numeroSalárioAumento = numeroSalário + (numeroSalário / 10);
            Console.Write($"Seu novo salário depois do aumento será de {numeroSalárioAumento}");
        }

        static void Exercise15()
        {
            //Décimo Quinto Exercício: Crie uma variável do tipo string e concatene com outra variável para formar uma frase.
            Console.WriteLine("Fale seu nome por favor.");
            string nomeUsuarioQuinze = Console.ReadLine();
            Console.WriteLine("Seu dia foi bom ou ruim?");
            string diaUsuarioQuinze = Console.ReadLine();
            Console.Write($"Olá {nomeUsuarioQuinze}, então seu dia foi {diaUsuarioQuinze}, entendo.");
        }

        static void Exercise16()
        {
            //Décimo Sexto Exercício: Leia um número e calcule seu fatorial.

            CANCELADO
        }

        static void Exercise17()
        {

            //Décimo Sétimo Exercício: Crie um programa que leia um número decimal e converta para inteiro.
            Console.WriteLine("Informe um número decimal.");
            double numDecimalArredondando = Convert.ToDouble(Console.ReadLine());
            int numDecimalArredondandoDepois = Convert.ToInt32(numDecimalArredondando);
            Console.WriteLine($"O número informado, arredondado ele, fica: {numDecimalArredondandoDepois}.");
        }

        static void Exercise18()
        {
            //Décimo Oitavo Exercício: Verifique se um número fornecido pelo usuário está entre 1 e 100.
            Console.WriteLine("Me indique um número.");
            double numEntreUmECem = double.Parse(Console.ReadLine());
            Console.WriteLine($"O número {numEntreUmECem} está entre 1 e 100?");
            Console.WriteLine(1 < numEntreUmECem && 100 > numEntreUmECem);

        }

        static void Exercise19()
        {

            //Décimo Nono Exercício: Leia um texto e exiba o número de caracteres usando Length.
            Console.WriteLine("Por favor, escreva uma frase");
            string fraseDezenove = Console.ReadLine();
            int fraseDezenoveNumCaracteres = fraseDezenove.Length;
            Console.WriteLine($"Essa frase tem {fraseDezenoveNumCaracteres} caracteres");
        }

        static void Exercise20()
        {

            //Vigésimo Exercício: Receba duas strings e compare se elas são iguais, ignorando maiúsculas e minúsculas.
            Console.WriteLine("Por favor, escreva uma frase");
            string fraseVintePrim = Console.ReadLine();
            Console.WriteLine("Por favor, escreva mais uma frase");
            string fraseVinteSeg = Console.ReadLine();
            fraseVintePrim = fraseVintePrim.ToUpper();
            fraseVinteSeg = fraseVinteSeg.ToUpper();
            Console.WriteLine("As duas frases são iguais, desconsiderando maiúsculas e minúsculas?");
            Console.Write(fraseVintePrim == fraseVinteSeg);
        }


    }
}
