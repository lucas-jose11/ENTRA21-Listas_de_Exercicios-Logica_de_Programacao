//Lista 05 - Funções
try
{
    int auxSaida = 1;
    while (auxSaida != 0)
    {

        Console.WriteLine("Escolha um exercício:");
        Console.WriteLine("1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.\n2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.\n3. Desenvolva uma função que verifique se um número é primo ou não.\n4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.\n5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).\n6. Escreva uma função que calcule a média de uma lista de números reais.\n7. Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.\n8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.\n9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.\n10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.\n11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.\n12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.\n13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.\n14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.\n15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.\n16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.\n17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.\n18: Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.\n19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.\n20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.\n-------APERTE 0 PARA SAIR.-------");
        int escolherExercicio;
        while (true)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out escolherExercicio))
            {
                break;
            }
        }
        Console.Clear();

        switch (escolherExercicio)
        {
            case 0:
                auxSaida = 0;
                Console.WriteLine("Saindo...");
                break;

            case 1:
                Console.WriteLine("Exercício 1 - Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.");

                Console.WriteLine("Digite um número");
                int numA = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                int numB = int.Parse(Console.ReadLine());

                Console.WriteLine($"A soma de ambos os números é {Soma(numA, numB)}");
                Console.Read();
                Console.Clear();

                break;

            case 2:
                Console.WriteLine("Exercício 2 - Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.");
                Console.WriteLine("Digite um número positivo pra ver seu fatorial");
                int numC = int.Parse(Console.ReadLine());

                if (numC == 0 || numC == 1)
                {
                    Console.WriteLine("O fatorial desse número é 1");
                }
                else
                {
                    Console.WriteLine(Fatorial(numC));
                }
                Console.Read();
                Console.Clear();

                break;

            case 3:
                Console.WriteLine("Exercício 3 - Desenvolva uma função que verifique se um número é primo ou não.");
                Console.WriteLine("Digite um número inteiro");
                int numD = int.Parse(Console.ReadLine());

                Console.WriteLine($"O número {numD} {PrimOuNão(numD)}");
                Console.Read();
                Console.Clear();

                break;

            case 4:
                Console.WriteLine("Exercício 4 - Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.");
                Console.WriteLine("Crie uma lista de números inteiros, quantos números ela terá?");
                int quantosNumeros = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------");
                List<int> ints = new List<int>(quantosNumeros);

                for (int i = 0; i < quantosNumeros; i++)
                {
                    Console.WriteLine($"Escreva o número #{i + 1}:");
                    ints.Add(int.Parse(Console.ReadLine()));
                }

                Console.WriteLine("----------------------");
                Console.WriteLine($"O maior número dentro da lista é o {QualMaiorNumeroNaLista(ints)}");
                Console.Read();
                Console.Clear();

                break;

            case 5:
                Console.WriteLine("Exercício 5 - Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).");
                Console.WriteLine("Digita-me uma frase");
                string frasePraInverter = Console.ReadLine();

                Console.WriteLine($"O inverso dela é {FraseInvertida(frasePraInverter)}");
                Console.Read();
                Console.Clear();

                break;

            case 6:
                Console.WriteLine("Exercício 6 -  Escreva uma função que calcule a média de uma lista de números reais.");
                Console.WriteLine("Teremos um array de 5 números nesse exercício, por favor, fale quais são, lembrando que são números reais e não pode escrever frações");
                double[] numsL5Ex6 = new double[5];
                for (int i = 0; i < numsL5Ex6.Length; i++)
                {
                    Console.WriteLine("Escreva um número:");
                    numsL5Ex6[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"A média aritmética da sua lista é {MediaAritmetica(numsL5Ex6)}");
                Console.Read();
                Console.Clear();

                break;

            case 7:
                Console.WriteLine("Exercício 7 -  Desenvolva uma função que verifique se uma string é um palíndromo (ela lê o mesmo de trás para frente) ou não.");
                Console.WriteLine("Escreva a frase para ver se ela é palíndroma ou não.");
                string frasePraPalindromar = Console.ReadLine();

                Console.WriteLine($"A frase é palíndroma? {FrasePalindroma(frasePraPalindromar)}");
                Console.Read();
                Console.Clear();

                break;

            case 8:
                Console.WriteLine("Exercício 8 - Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.");
                Console.WriteLine("Informe a temperatura em graus Celsius");
                double TempC = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Em Fahrenheit é {TemperaturaCparaF(TempC)}º graus");
                Console.Read();
                Console.Clear();

                break;

            case 9:
                Console.WriteLine("Exercício 9 - Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.");
                Console.WriteLine("Você fará parte desse exercício, quantas strings o array terá?");
                int numArray = int.Parse(Console.ReadLine());

                string[] frases = new string[numArray];
                for (int i = 0; i < frases.Length; i++)
                {
                    Console.WriteLine("Escreva a string:");
                    frases[i] = Console.ReadLine();
                }

                var resultado = StringsMaisQue5Caracters(frases);

                Console.WriteLine($"---------------------\nSão {resultado.Count} strings que tem mais de 5 caracteres, que são:");

                foreach (string elemento in resultado)
                {
                    Console.WriteLine(elemento);
                }

                Console.ReadLine();
                Console.Clear();

                break;

            case 10:
                Console.WriteLine("Exercício 10 - Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.");
                Console.WriteLine("Escreva dois números inteiros, A e B, sendo B o maior deles");
                Console.WriteLine("Número A:");
                int A = int.Parse(Console.ReadLine());
                Console.WriteLine("Número B:");
                int B = int.Parse(Console.ReadLine());

                int resultadoMDC = (CalcularMDC(A, B));
                Console.WriteLine($"O MDC de {A} e {B} é {resultadoMDC}");

                Console.ReadLine();
                Console.Clear();

                break;

            case 11:
                Console.WriteLine("Exercício 11 - Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.");
                Console.WriteLine("Escreva uma lista de números, quantos números serão?");
                int numArray11 = int.Parse(Console.ReadLine());

                int[] numeros = new int[numArray11];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Escreva um número:");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                var resultadopares = ListaQueDevolveNumerosPares(numeros);
                if (resultadopares.Count < 1)
                {
                    Console.WriteLine("Não há números pares nessa lista.");
                }
                else
                {
                    Console.WriteLine("---------------------\nOs números pares são esses:");

                    foreach (string elemento in resultadopares)
                    {
                        Console.WriteLine(elemento);
                    }
                }
                Console.Read();
                Console.Clear();

                break;

            case 12:
                Console.WriteLine("Exercício 12 - Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.");
                Console.WriteLine("Lista de números:\n1, 2, 3, 0, 5, 7, 4, 2, 0, 3\n9, 2, 1, 2, 3, 1, 0, 0, 9, 8\n7, 5, 8, 6, 0, 2, 5, 6, 7, 2\n4, 2, 5, 0, 6, 2, 8, 8, 3, 7");
                int[] listaNumeros = { 1, 2, 3, 0, 5, 7, 4, 2, 0, 3, 9, 2, 1, 2, 3, 1, 0, 0, 9, 8, 7, 5, 8, 6, 0, 2, 5, 6, 7, 2, 4, 2, 5, 0, 6, 2, 8, 8, 3, 7 };
                Console.WriteLine("Qual número você gostaria de saber quantas vezes aparece na lista? 0-9");
                int buscador = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"O número {buscador} aparece {QuantasVezesONumeroApareceNaLista(listaNumeros, buscador)}");
                Console.Read();
                Console.Clear();

                break;

            case 13:
                Console.WriteLine("Exercício 13 - Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.");
                Console.WriteLine("Escreva uma string para suas letras serem invertidas de tamanho");
                string fraseCapsLock = Console.ReadLine();

                Console.WriteLine($"------------------\nA frase invertida fica: {InverterCapsLock(fraseCapsLock)}");
                Console.Read();
                Console.Clear();

                break;

            case 14:
                Console.WriteLine("Exercício 14 - Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.");
                Console.WriteLine("Qual é o número do termo na sequência de Fibonaci que você quer saber?");
                int fibonaciNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{fibonaciNumber}º número da sequeência de fibonaci é {Fibonacci(fibonaciNumber)}.");
                Console.Read();
                Console.Clear();

                break;

            case 15:
                Console.WriteLine("Exercício 15 - Desenvolva uma função que determine se um número é positivo, negativo ou zero.");
                Console.WriteLine("Escreva um número.");
                int numPraDescobrir = int.Parse(Console.ReadLine());

                Console.WriteLine($"---------------\n{DeterminarPolaridade(numPraDescobrir)}");
                Console.Read();
                Console.Clear();

                break;

            case 16:
                Console.WriteLine("Exercício 16 - Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.");
                Console.WriteLine("Calculadora.");
                Console.WriteLine("Qual o primeiro número?");
                double numCalcular1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o segundo número?");
                double numCalcular2 = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------");
                Console.WriteLine("Que operação realizar?\n1 para adição.\n2 para subtração.\n3 para multiplicação.\n4 para divisão.\n5 para sair.");
                Console.WriteLine("----------------------");
                int respostaOperaçãoCalculadora = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nResultado da operação: {Calculadora(respostaOperaçãoCalculadora, numCalcular1, numCalcular2)}");
                Console.Read();
                Console.Clear();

                break;

            case 17:
                Console.WriteLine("Exercício 17 - Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.");

                Console.WriteLine("Este exercício é igual ao Exercício 3.");
                Console.WriteLine("Aperte ENTER para voltar.");
                Console.Read();
                Console.Clear();

                break;

            case 18:
                Console.WriteLine("Exercício 18 - Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.");

                Console.WriteLine("Quais são os n primeiros números da sequência de Fibonaci que você quer saber?");
                string fibonaciNumber2 = Console.ReadLine();

                if (Convert.ToInt32(fibonaciNumber2) == 1)
                {
                    Console.WriteLine("O primeiro termo da sequência de fibonacci é esse:\n-----------------------");
                    Console.WriteLine(FibonacciLista(fibonaciNumber2));
                }
                else
                {
                    Console.WriteLine($"Os {fibonaciNumber2} primeiros termos da sequência de fibonacci são esses:\n-----------------------");
                    Console.WriteLine(FibonacciLista(fibonaciNumber2));
                }
                Console.Read();
                Console.Clear();

                break;

            case 19:
                Console.WriteLine("Exercício 19 - Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.");
                Console.WriteLine("Escreva um número inteiro para ver quantos dígitos ele tem.");
                long numeroDigitos = Convert.ToInt64(Console.ReadLine());

                if (numeroDigitos <= 9 && numeroDigitos >= -9)
                {
                    Console.WriteLine("Existe 1 dígito nesse número.");
                }
                else
                {
                    Console.WriteLine($"Existem {ContarDigitos(numeroDigitos)} dígitos nesse número.");
                }
                Console.Read();
                Console.Clear();

                break;

            case 20:
                Console.WriteLine("Exercício 20 - Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.");
                Console.WriteLine("Escreva 3 números para ser calculada a média entre eles.");

                double[] numerosParaMediar = new double[3];
                int contador = 0;

                foreach (var i in numerosParaMediar)
                {
                    Console.WriteLine($"Escreva o {contador + 1}º número da lista:");
                    numerosParaMediar[contador] = double.Parse(Console.ReadLine());
                    contador++;
                }

                Console.WriteLine($"A média dos três números é {CalcularMedia(numerosParaMediar)}.");
                Console.Read();
                Console.Clear();

                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}
catch (DivideByZeroException)
{
    Console.WriteLine("Tentou dividir por 0.");
}
catch (FormatException extipo)
{
    Console.WriteLine($"Entrada de tipo inválida. {extipo.Message}.");
}
catch (System.OutOfMemoryException)
{
    Console.WriteLine("Não tem memória suficiente para continuar a execução.");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro inesperado: {ex.Message}.");
}


static int Soma(int numA, int numB)
{
    return (numA + numB);
}

static int Fatorial(int numC)
{
    for (int i = numC - 1; i >= 1; i--)
    {
        Console.WriteLine($"{numC} * {i} = {numC * i}");
        numC = numC * i;

    }
    return numC;
}

static string PrimOuNão(int numD)
{
    bool primo = true;

    for (int i = numD - 1; i > 1; i--)
    {
        if (numD % i == 0) primo = false;
    }
    return primo ? "é primo" : "não é primo";
}

static int QualMaiorNumeroNaLista(List<int> ints)
{
    int maiorNumero = 0;

    for (int i = 0; i < ints.Count; i++)
    {
        if (ints[i] > maiorNumero)
        {
            maiorNumero = ints[i];
        }
    }
    return maiorNumero;
}

static string FraseInvertida(string frasePraInverter)
{
    char[] fraseNormal = frasePraInverter.ToCharArray();
    string fraseInverso = string.Empty;
    for (int i = fraseNormal.Length - 1; i >= 0; i--)
    {
        fraseInverso += fraseNormal[i];
    }

    return fraseInverso;
}

static double MediaAritmetica(Array numsL5Ex6)
{
    double somaTodos = 0, mediaArit = 0;
    int qntdArray = 0;

    foreach (double i in numsL5Ex6)
    {
        somaTodos += i;
        qntdArray += 1;
    }
    mediaArit = somaTodos / qntdArray;

    return mediaArit;
}

static bool FrasePalindroma(string frasePraPalindromar)
{
    bool ehPalindroma;
    char[] fraseNormalPalindroma = frasePraPalindromar.ToCharArray();
    string fraseInversoPalindroma = string.Empty;

    for (int i = fraseNormalPalindroma.Length - 1; i >= 0; i--)
    {
        fraseInversoPalindroma += fraseNormalPalindroma[i];
    }

    if (fraseInversoPalindroma.Equals(frasePraPalindromar))
    {
        ehPalindroma = true;
    }
    else
    {
        ehPalindroma = false;
    }

    return ehPalindroma;
}

static double TemperaturaCparaF(double tempC)
{
    double TempF;
    TempF = ((tempC * 9) / 5) + 32;
    return TempF;
}

static List<string> StringsMaisQue5Caracters(String[] frases)
{
    var aux = 5;
    var maiorque5 = new List<string>();

    foreach (var i in frases)
    {
        if (i.Length > aux)
        {
            maiorque5.Add(i);
        }
    }
    return maiorque5;
}

static int CalcularMDC(int A, int B)
{
    while (B != 0)
    {
        int auxMDC = B;
        B = A % B;
        A = auxMDC;
    }
    return A;
}

static List<string> ListaQueDevolveNumerosPares(int[] numeros)
{
    var listaNumerosPares = new List<string>();

    foreach (var i in numeros)
    {
        if (i % 2 == 0)
        {
            listaNumerosPares.Add(i.ToString());
        }
    }
    return listaNumerosPares;
}

static int QuantasVezesONumeroApareceNaLista(IList<int> listaNumeros, int buscador)
{
    int quantoAparece = 0;

    foreach (var i in listaNumeros)
    {
        if (i == buscador)
        {
            quantoAparece++;
        }
    }
    return quantoAparece;
}

static string InverterCapsLock(String fraseCapsLock)
{
    string fraseInvertidaCapsLock = "";

    foreach (char c in fraseCapsLock)
    {
        if (char.IsLower(c))
        {
            fraseInvertidaCapsLock += char.ToUpper(c);
        }
        else
        {
            fraseInvertidaCapsLock += char.ToLower(c);
        }
    }
    return fraseInvertidaCapsLock;
}

static string DeterminarPolaridade(int numPraDescobrir)
{
    string determinaçãoPolaridade = "";

    if (numPraDescobrir > 0)
    {
        determinaçãoPolaridade = "o número é positivo";
    }
    else if (numPraDescobrir < 0)
    {
        determinaçãoPolaridade = "o número é negativo";
    }
    else
    {
        determinaçãoPolaridade = "o número é neutro, é zero";
    }
    return determinaçãoPolaridade;
}

static double Calculadora(int respostaOperaçãoCalculadora, double numCalcular1, double numCalcular2)
{
    double resultadoOperação = 0;

    switch (respostaOperaçãoCalculadora)
    {
        case 1:
            Console.WriteLine("------------------------------");
            resultadoOperação = numCalcular1 + numCalcular2;
            break;

        case 2:
            Console.WriteLine("------------------------------");
            resultadoOperação = numCalcular1 - numCalcular2;
            break;

        case 3:
            Console.WriteLine("------------------------------");
            resultadoOperação = numCalcular1 * numCalcular2;
            break;

        case 4:
            Console.WriteLine("------------------------------");
            resultadoOperação = numCalcular1 / numCalcular2;
            break;
    }
    return resultadoOperação;
}

static int Fibonacci(int fibonaciNumber)
{
    int termo1 = 0;
    int termo2 = 1;
    int proximo = 0;

    for (int i = 2; i < fibonaciNumber; i++)
    {
        proximo = termo1 + termo2;

        termo1 = termo2;
        termo2 = proximo;

        if (fibonaciNumber == 1)
        {
            proximo = 0;
        }
        else if (fibonaciNumber == 2)
        {
            proximo = 1;
        }
    }
    return proximo;
}

static string FibonacciLista(String fibonaciNumber2)
{
    string seAVariavelForNegativa = "Insira um valor válido";
    string seAVariavelForZero = "";
    string seAVariavelForUm = "0";
    string seAVariavelForDois = "0, 1";
    string listaDosNumerosFibonacci = "0, 1, ";

    int auxFibonacci = int.Parse(fibonaciNumber2);
    int termo1 = 0;
    int termo2 = 1;
    int proximo;

    for (int i = 2; i < auxFibonacci; i++)
    {
        proximo = termo1 + termo2;
        listaDosNumerosFibonacci += proximo + ", ";

        termo1 = termo2;
        termo2 = proximo;
    }

    if (listaDosNumerosFibonacci.Length > 0)
    {
        listaDosNumerosFibonacci = listaDosNumerosFibonacci.Substring(0, listaDosNumerosFibonacci.Length - 2);
    }

    if (auxFibonacci < 0)
    {
        return seAVariavelForNegativa;
    }
    else if (auxFibonacci == 0)
    {
        return seAVariavelForZero;
    }
    else if (auxFibonacci == 1)
    {
        return seAVariavelForUm;
    }
    else
    {
        return listaDosNumerosFibonacci;
    }
}

static int ContarDigitos(long numeroDigitos)
{
    string digitosNoNumero = numeroDigitos.ToString();
    int auxContagem = 0;

    foreach (var i in digitosNoNumero)
    {
        auxContagem++;
    }

    if (numeroDigitos < 0)
    {
        auxContagem -= 1;
    }
    return auxContagem;
}

static double CalcularMedia(Array numerosParaMediar)
{
    double somaDeTodos = 0;
    int qntsNumeros = 0;

    foreach (double num in numerosParaMediar)
    {
        somaDeTodos += num;
        qntsNumeros++;
    }
    double mediaDosTresNumeros = somaDeTodos / qntsNumeros;

    return mediaDosTresNumeros;
}