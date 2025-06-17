//Lista 08 - Lógica de programação - Recursividade
bool caiuCatch = false;
int respostaUsuario;
do
{
    Console.WriteLine("Exercícios de Recursividade.");
    Console.WriteLine("Escolha qual você quer ver:");

    Console.WriteLine("[1] Potência - Implemente uma função recursiva chamada Potencia que recebe " +
        "dois parâmetros base e expoente e calcula a potência de base elevado a expoente." +

        "\n[2] Soma de Números Inteiros - Crie uma função recursiva chamada Soma que recebe " +
        "um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n." +

        "\n[3] Fibonacci - Desenvolva uma função recursiva chamada Fibonacci que recebe " +

        "um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci." +
        "\n[4] Contagem Regressiva - Escreva uma função recursiva chamada ContagemRegressiva que recebe " +
        "um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1." +

        "\n[5] Máximo Divisor Comum (MDC) - Crie uma função recursiva chamada MDC que recebe " +
        "dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles." +

        "\n[0] PARA SAIR.");

    bool entradaValida = false;
    respostaUsuario = -1;

    while (!entradaValida)
    {
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out respostaUsuario))
        {
            if (respostaUsuario >= 0 && respostaUsuario <= 5)
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
    try
    {
        switch (respostaUsuario)
        {
            case 0:
                Console.WriteLine("Saindo...");
                break;

            case 1:
                Exercicio1();
                break;

            case 2:
                Exercicio2();
                break;

            case 3:
                Exercicio3();
                break;

            case 4:
                Exercicio4();
                break;

            case 5:
                Exercicio5();
                break;

            default:
                Console.WriteLine("Opção inválida. Digite uma opção válida.");
                break;
        }
    }
    catch (FormatException tipo)
    {
        Console.WriteLine($"Entrada de tipo inválida. {tipo.Message}.");
        caiuCatch = true;
    }
    catch (System.OutOfMemoryException)
    {
        Console.WriteLine("Não tem memória suficiente para continuar a execução.");
        caiuCatch = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro do tipo {ex.Message}.");
        caiuCatch = true;
    }

} while (respostaUsuario != 0 && caiuCatch == false);


static void Exercicio1()
{
    Console.WriteLine("Exercício 1: Potência - Implemente uma função recursiva chamada Potencia que recebe " +
        "dois parâmetros base e expoente e calcula a potência de base elevado a expoente.");
    Random aleatorio = new Random();
    int numero = aleatorio.Next(2, 10);
    int potencia = aleatorio.Next(3, 6);
    Console.WriteLine($"Base:{numero}" +
        $"\nPotência:{potencia}" +
        $"\nResultado:{Potencia(numero, potencia)}");
    Console.ReadLine();
    Console.Clear();
}

static void Exercicio2()
{
    Console.WriteLine("Exercício 2: Soma de Números Inteiros - Crie uma função recursiva chamada Soma que recebe " +
        "um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.");
    Console.WriteLine("Escreva um número inteiro n para ver a somatória de 1 até n.");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"---------------\nA somátoria de 1 até {n} é {SomatoriaRetroativa(n)}.");
    Console.ReadLine();
    Console.Clear();
}

static void Exercicio3()
{
    Console.WriteLine("Exercício 3: Fibonacci - Desenvolva uma função recursiva chamada Fibonacci que recebe " +
        "um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci.");
    Console.WriteLine("Diga um número inteiro n, mostrarei o n-ésimo termo de Fibonacci.");
    int numPraFibonatar;
    do
    {
        numPraFibonatar = int.Parse(Console.ReadLine());
        if (numPraFibonatar == 0)
        {
            Console.WriteLine("Não existe o 0º número de Fibonacci, escreva algum número inteiro válido\n-----------------");
        }
        else if (numPraFibonatar < 0)
        {
            Console.WriteLine("Por favor, escreva um número inteiro positivo.\n----------------------");
        }
    } while (numPraFibonatar < 1);

    Console.WriteLine($"Aqui está: {Fibonacci(numPraFibonatar)}");
    Console.ReadLine();
    Console.Clear();
}

static void Exercicio4()
{
    Console.WriteLine("Exercício 4: Contagem Regressiva - Escreva uma função recursiva chamada ContagemRegressiva que recebe " +
        "um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1.");
    Console.WriteLine("Escreva um número inteiro n para ver a contagem regressiva de n até 1.");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"---------------\nA contagem regressiva de {n} até 1 é: \n-----");
    Console.WriteLine(ContagemRegressiva(n));
    Console.ReadLine();
    Console.Clear();
}

static void Exercicio5()
{
    Console.WriteLine("Exercício 5: Máximo Divisor Comum (MDC) - Crie uma função recursiva chamada MDC que recebe " +
        "dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.");
    Console.WriteLine("Me fale o número inteiro A:");
    int numeroA = int.Parse(Console.ReadLine());
    Console.WriteLine("Me fale o número inteiro B:");
    int numeroB = int.Parse(Console.ReadLine());

    Console.WriteLine($"O maior divisor comum entre eles é {MDC(numeroA, numeroB)}.");
    Console.ReadLine();
    Console.Clear();
}


static int Potencia(int numero, int potencia)
{
    if (potencia == 1)
    {
        return numero;
    }
    return numero * Potencia(numero, potencia - 1);
}

static int SomatoriaRetroativa(int n)
{
    if (n == 1)
    {
        return 1;
    }
    return n + (SomatoriaRetroativa(n - 1));
}

static int Fibonacci(int n)
{
    if (n == 1)
    {
        return 0;
    }
    else if (n == 2)
    {
        return 1;
    }
    return n = Fibonacci(n - 1) + Fibonacci(n - 2);
}

static int ContagemRegressiva(int n)
{
    if (n == 1)
    {
        return 1;
    }
    Console.WriteLine(n);
    return ContagemRegressiva(n - 1);
}

static int MDC(int a, int b)
{
    if (b == 0)
    {
        return a;
    }
    return MDC(b, a % b);
}