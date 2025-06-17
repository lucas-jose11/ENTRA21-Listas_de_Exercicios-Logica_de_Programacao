//Lista 06 - Vetores e Listas
try
{
    bool menuPrincipal = true;
    while (menuPrincipal == true)
    {
        Console.WriteLine("Menu Principal. Para avançar, escolha um assunto de exercícios.");
        Console.WriteLine("[1] para Exercícios de Vetores/Arrays.\n[2] para Exercícios de Lists.\n[0] PARA SAIR.");

        int assuntoExercícios = -1;
        bool entradaValida = false;

        while (!entradaValida)
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out assuntoExercícios))
            {
                if (assuntoExercícios >= 0 && assuntoExercícios <= 2)
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

        if (assuntoExercícios == 0)
        {
            Console.Clear();
            Console.WriteLine("Saindo...");
            menuPrincipal = false;
        }

        if (assuntoExercícios == 1)
        {
            int arrayExercícios;
            do
            {
                Console.WriteLine("Exercícios de Vetores/Arrays." +
                    "\n[1] - Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos." +
                    "\n[2] - Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais." +
                    "\n[3] - Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares." +
                    "\n[4] - Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário." +
                    "\n[5] - Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor (não utilizar função pronta)." +
                    "\n[6] - Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor." +
                    "\n[7] - Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente." +
                    "\n[0] - PARA SAIR.");
                Console.WriteLine("Qual exercício você quer ver?");
                arrayExercícios = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (arrayExercícios)
                {
                    case 1:
                        Ex1Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Ex2Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Ex3Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Ex4Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Ex5Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        Ex6Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 7:
                        Ex7Array();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:

                        break;
                }

            } while (arrayExercícios != 0);
        }

        if (assuntoExercícios == 2)
        {
            int listExercícios;
            do
            {
                Console.WriteLine("Exercícios de Listas." +
                   "\n[1] - Crie uma List de inteiros e adicione os números de 1 a 5. Exiba os números no console." +
                   "\n[2] - Crie uma List de números inteiros. Solicite ao usuário para digitar 5 números e adicione-os à lista. Em seguida, calcule e exiba a soma de todos os números." +
                   "\n[3] - Crie uma List de inteiros com 6 valores pré-definidos. Percorra a lista e encontre o maior número. Exiba o maior valor no console." +
                   "\n[4] - Crie uma List de strings com nomes de frutas (\"banana\", \"maçã\", \"uva\", \"laranja\"). Solicite ao usuário uma fruta para remover e remova-a da lista. Exiba a lista atualizada." +
                   "\n[5] - Crie uma List de números inteiros. Adicione 10 números quaisquer à lista e conte quantos números são maiores que 50. Exiba o resultado." +
                   "\n[6] - Crie uma List de nomes (\"Ana\", \"Bruno\", \"Carlos\", \"Diana\", \"Eduardo\"). Pergunte ao usuário por um nome e informe se ele está presente na lista." +
                   "\n[7] - Crie uma List de números inteiros contendo pelo menos 5 elementos. Remova o primeiro e o último elemento da lista e exiba os valores restantes." +
                   "\n[0] - PARA SAIR.");
                Console.WriteLine("Qual exercício você quer ver?");
                listExercícios = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (listExercícios)
                {
                    case 1:
                        Ex1List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Ex2List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Ex3List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Ex4List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Ex5List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        Ex6List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 7:
                        Ex7List();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:

                        break;
                }

            } while (listExercícios != 0);
        }

        if (assuntoExercícios != 0 && assuntoExercícios != 1 && assuntoExercícios != 2)
        {
            Console.WriteLine("OPÇÃO INVÁLIDA\n----------------------");
        }

    }
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


static void Ex1Array()
{
    Console.WriteLine("Exercício 1:");
    Console.WriteLine("1.Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.");

    Console.WriteLine("Escreva cinco números inteiros para calcular sua média.");
    int[] cincoNumeros = new int[5];

    for (var i = 0; i < cincoNumeros.Length; i++)
    {
        Console.WriteLine("Escreva um número:");
        cincoNumeros[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine($"A média aritmética entre os números é {MediaDosInteiros(cincoNumeros)}");
}

static void Ex2Array()
{
    Console.WriteLine("Exercício 2:");
    Console.WriteLine("2. Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o " +
        "menor valor em um vetor de números reais.");

    Console.WriteLine("Quantos valores terá seu vetor de números reais?");
    int numeroDeItens = int.Parse(Console.ReadLine());

    double[] numerosReais = new double[numeroDeItens];

    for (var i = 0; i < numerosReais.Length; i++)
    {
        Console.WriteLine("Escreva um número");
        numerosReais[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine(RetornaMaiorMenorValor(numerosReais));

}

static void Ex3Array()
{
    Console.WriteLine("Exercício 3:");
    Console.WriteLine("3. Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: " +
        "um contendo os números pares e outro os números ímpares.");

    Console.WriteLine("Existe um vetor: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.");
    int[] parEImpar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] pares = new int[Pares(parEImpar)];
    int[] impares = new int[parEImpar.Length - Pares(parEImpar)];

    Console.WriteLine("Ele é dividido em dois vetores, de números pares e ímpares.");

    int contPAR = 0;
    int contIMP = 0;
    foreach (int i in parEImpar)
    {
        if (i % 2 == 0)
        {
            pares[contPAR] = i;
            contPAR++;
        }
        else
        {
            impares[contIMP] = i;
            contIMP++;
        }
    }
    Console.WriteLine("----------------------------\nOs dois vetores ficam agora:");

    Console.WriteLine($"Pares {PrintVetor(pares)}");
    Console.WriteLine($"Impares {PrintVetor(impares)}");

}

static void Ex4Array()
{
    Console.WriteLine("Exercício 4:");
    Console.WriteLine("4.Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. " +
        "A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.");

    Console.WriteLine("Existe esse vetor:");
    Console.WriteLine("9, 112, 68, 137, 53, 17, 131, 109, 101, 20, 105, 52, 77, 19, 135, " +
        "32, 124, 46, 81, 59, 89, 27, 22, 42, 39, 134, 90, 62, 121, 129, 97, 104, 47, 44, 98, 37, " +
        "7, 28, 50, 115, 23, 118, 70, 60, 67, 116, 126, 95, 100, 16, 108, 136, 73, 26, 107, 30, 24, 40, " +
        "117, 82, 130, 13, 57, 54, 33, 61, 119, 12, 43, 71, 103, 127, 56, 4, 64, 55, 88, 1, 25, 72, 114, 6, 99, 34, 10, 113");

    int[] arrayNumeros = {9, 112, 68, 137, 53, 17, 131, 109, 101, 20, 105, 52, 77, 19, 135,
                32, 124, 46, 81, 59, 89, 27, 22, 42, 39, 134, 90, 62, 121, 129, 97, 104, 47, 44, 98, 37,
                7, 28, 50, 115, 23, 118, 70, 60, 67, 116, 126, 95, 100, 16, 108, 136, 73, 26, 107, 30, 24, 40,
                117, 82, 130, 13, 57, 54, 33, 61, 119, 12, 43, 71, 103, 127, 56, 4, 64, 55, 88, 1, 25, 72, 114, 6, 99, 34, 10, 113};

    Console.WriteLine("Indique um número inteiro para procurar se ele existe no vetor");
    int procurarNoVetor = int.Parse(Console.ReadLine());

    Console.WriteLine($"--------------------------\n{ConferirValorVetor(arrayNumeros, procurarNoVetor)}");
}

static void Ex5Array()
{
    Console.WriteLine("Exercício 5:");
    Console.WriteLine("5. Inversão de Vetor: Escreva um programa que inverte " +
        "a ordem dos elementos em um vetor (não utilizar função pronta).");

    Console.WriteLine("Existe o vetor de char: A, B, C, D, E, F.");
    char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F' };

    foreach (char c in InverterVetor(chars))
    {
        if (c == 'A')
        {
            Console.WriteLine($"{c}.");
        }
        else
        {
            Console.Write($"{c}, ");
        }
    }
}

static void Ex6Array()
{
    Console.WriteLine("Exercício 6:");
    Console.WriteLine("6. Contagem de Elementos: Implemente uma função que conta " +
        "quantas vezes um determinado valor aparece em um vetor.");
    Console.WriteLine("Lista de números:\n1, 2, 3, 0, 5, 7, 4, 2, 0, 3\n9, 2, 1, 2, 3, 1, 0, 0, 9, 8\n7, 5, 8, 6, 0, 2, 5, 6, 7, 2\n" +
           "4, 2, 5, 0, 6, 2, 8, 8, 3, 7\n2, 3, 5, 9, 0, 1, 4, 2, 6, 4\n5, 5, 3, 3, 4, 2, 9, 3, 1, 0\n0, 1, 2, 4, 7, 5, 8, 9, 6, 8");
    int[] listaNumeros = { 1, 2, 3, 0, 5, 7, 4, 2, 0, 3, 9, 2, 1, 2, 3, 1, 0, 0, 9, 8, 7, 5, 8, 6, 0, 2, 5, 6, 7, 2, 4, 2,
                5, 0, 6, 2, 8, 8, 3, 7, 2, 3, 5, 9, 0, 1, 4, 2, 6, 4, 5, 5, 3, 3, 4, 2, 9, 3, 1, 0, 0, 1, 2, 4, 7, 5, 8, 9, 6, 8 };

    bool dentroDoIntervalo = false;
    int numeroEscolhido = -1;
    while (dentroDoIntervalo == false)
    {
        Console.WriteLine("Qual número você gostaria de saber quantas vezes aparece nesse vetor? Escreva um número entre o intervalo de 0 a 9");
        numeroEscolhido = int.Parse(Console.ReadLine());

        if (numeroEscolhido < 0 || numeroEscolhido > 9)
        {
            Console.WriteLine("Número inválido, digite um número entre 0 e 9.\n----------------------------------------");
        }
        else { dentroDoIntervalo = true; }
    }
    Console.WriteLine($"O número {numeroEscolhido} aparece {QuantasVezesAparece(listaNumeros, numeroEscolhido)} vezes.");
}

static void Ex7Array()
{
    Console.WriteLine("Exercício 7:");
    Console.WriteLine("7. Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados " +
        "e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.");
    int[] vetor1 = { 4, 2, 6, 5, 7 };
    int[] vetor2 = { 3, 1, 9, 8, 0 };

    Console.WriteLine($"Antes, os vetores eram esses:\n{PrintVetor(vetor1)}\n{PrintVetor(vetor2)}");
    Console.WriteLine("----------------------------\nAgora, mesclados e colocados em ordem crescente, o novo vetor fica assim:");
    foreach (int i in MesclaEOrdena(vetor1, vetor2))
    {
        Console.Write(i + " ");
    }
}


static void Ex1List()
{
    Console.WriteLine("Exercício 1:");
    Console.WriteLine("1. Crie uma List de inteiros e adicione os números de 1 a 5. Exiba os números no console.");

    List<int> listaDeInteiros = new List<int>();

    Console.WriteLine("Os inteiros da lista:");

    foreach (int i in AdicionaValores1a5(listaDeInteiros))
    {
        Console.WriteLine(i);
    }
}

static void Ex2List()
{
    Console.WriteLine("Exercício 2:");
    Console.WriteLine("2. Crie uma List de números inteiros. Solicite ao usuário para digitar 5 números e adicione-os à lista. " +
        "Em seguida, calcule e exiba a soma de todos os números.");

    Console.WriteLine("Ajude-me a criar uma lista de números inteiros. Você me diz 5 números e eu mostrarei a soma deles.");
    List<int> listaDoUsuario = new List<int>();

    Console.WriteLine($"-----------------------------\nA soma deles é {EscreveERetornaSomaTotal(listaDoUsuario)}. Obrigado!");
}

static void Ex3List()
{
    Console.WriteLine("Exercício 3:");
    Console.WriteLine("3.Crie uma List de inteiros com 6 valores pré-definidos. " +
        "Percorra a lista e encontre o maior número. Exiba o maior valor no console.");

    List<int> listaPreDefinida = new List<int>();
    listaPreDefinida.Add(93);
    listaPreDefinida.Add(2);
    listaPreDefinida.Add(23);
    listaPreDefinida.Add(87);
    listaPreDefinida.Add(100);
    listaPreDefinida.Add(11);

    Console.WriteLine("Existe a lista:");
    foreach (int i in listaPreDefinida)
    {
        if (i == 11)
        {
            Console.WriteLine($"{i}.");
        }
        else { Console.Write($"{i}, "); }
    }

    Console.WriteLine($"O maior número da lista é {VoltaMaiorNumeroLista(listaPreDefinida)}.");
}

static void Ex4List()
{
    Console.WriteLine("Exercício 4:");
    Console.WriteLine("4.Crie uma List de strings com nomes de frutas(\"banana\", \"maçã\", \"uva\", \"laranja\"). " +
        "Solicite ao usuário uma fruta para remover e remova - a da lista. Exiba a lista atualizada.");

    List<string> listaDeFrutas = new List<string>();
    listaDeFrutas.Add("banana");
    listaDeFrutas.Add("maçã");
    listaDeFrutas.Add("uva");
    listaDeFrutas.Add("laranja");

    listaDeFrutas = RetirarFruta(listaDeFrutas);
    Console.WriteLine("--------------------------\nAgora a lista está assim:");
    Console.WriteLine(PrintLista(listaDeFrutas));
}

static void Ex5List()
{
    Console.WriteLine("Exercício 5:");
    Console.WriteLine("5. Crie uma List de números inteiros. " +
        "Adicione 10 números quaisquer à lista e conte quantos números são maiores que 50. Exiba o resultado.");

    List<int> numerosInteiros = new List<int>(10);
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Escreva o {i + 1}º número");
        numerosInteiros.Add(int.Parse(Console.ReadLine()));
    }
    Console.WriteLine($"Na lista temos {QuantosMaioresQue50(numerosInteiros)} números maiores que 50.");
}

static void Ex6List()
{
    Console.WriteLine("Exercício 6:");
    Console.WriteLine("6. Crie uma List de nomes (\"Ana\", \"Bruno\", \"Carlos\", \"Diana\", \"Eduardo\"). " +
        "Pergunte ao usuário por um nome e informe se ele está presente na lista.");

    string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };

    Console.WriteLine("Existe uma lista com 5 nomes, digite um nome para ver se ele está presente na lista.");
    string chuteDeNome = Console.ReadLine();

    Console.WriteLine($"O nome {chuteDeNome} {(ExisteONomeNaLista(nomes, chuteDeNome) ? "está" : "não está")} na lista.");
}

static void Ex7List()
{
    Console.WriteLine("Exercício 7:");
    Console.WriteLine("7. Crie uma List de números inteiros contendo pelo menos 5 elementos. " +
        "Remova o primeiro e o último elemento da lista e exiba os valores restantes.");

    int numeroItensLista;
    do
    {
        Console.WriteLine("Digite pelo menos 5 elementos na lista. Quantos itens ela terá?");
        numeroItensLista = int.Parse(Console.ReadLine());
        if (numeroItensLista < 5)
        {
            Console.WriteLine("Número iválido, pelo menos 5 elementos ela precisa ter\n------------------------------------------------------------------------------------");
        }
    } while (numeroItensLista < 5);

    List<string> listaElementos = new List<string>(numeroItensLista);

    for (int i = 0; i < numeroItensLista; i++)
    {
        Console.WriteLine($"Escreva a {i + 1}ª frase");
        listaElementos.Add(Console.ReadLine());
    }

    listaElementos.RemoveAt(0);
    listaElementos.RemoveAt(listaElementos.Count - 1);

    Console.WriteLine("A lista, depois de retirar o primeiro e o último elemento, fica:");
    Console.WriteLine(PrintLista(listaElementos));
}


static double MediaDosInteiros(int[] cincoNumeros)
{
    double auxSomadeTodos = 0;
    foreach (var i in cincoNumeros)
    {
        auxSomadeTodos += i;
    }
    double aux = (auxSomadeTodos / cincoNumeros.Length);
    return aux;
}

static string RetornaMaiorMenorValor(double[] numerosReais)
{

    if (numerosReais.Length == 0)
    {
        string respostaEx2ArrayZero = "Escreva pelo menos algum número.";
        return respostaEx2ArrayZero;
    }
    else if (numerosReais.Length == 1)
    {
        double menorNum = numerosReais[0];
        string respostaEx2ArrayUm = $"O maior e o menor número são o mesmo, é {menorNum}";
        return respostaEx2ArrayUm;
    }
    else
    {
        Array.Sort(numerosReais);
        double menorNum = numerosReais[0];
        double maiorNum = numerosReais[numerosReais.Length - 1];

        string respostaEx2Array = $"O menor número é {menorNum} e o maior número é {maiorNum}";

        return respostaEx2Array;

    }
}

static string PrintVetor(int[] numeros)
{
    return string.Join(",", numeros) + ".";
}

static int Pares(int[] numeros)
{
    int pares = 0;
    foreach (int i in numeros)
    {
        if (i % 2 == 0)
        {
            pares++;
        }
    }
    return pares;
}

static bool ConferirValorVetor(int[] arrayNumeros, int procurarNoVetor)
{
    bool confereValor = false;
    foreach (var i in arrayNumeros)
    {
        if (i == procurarNoVetor)
        {
            confereValor = true;
        }
    }
    return confereValor;
}

static char[] InverterVetor(char[] chars)
{
    char[] copiaDechars = (char[])chars.Clone();

    chars[0] = copiaDechars[5];
    chars[1] = copiaDechars[4];
    chars[2] = copiaDechars[3];
    chars[3] = copiaDechars[2];
    chars[4] = copiaDechars[1];
    chars[5] = copiaDechars[0];

    return chars;
}

static int QuantasVezesAparece(int[] listaNumeros, int numeroEscolhido)
{
    int quantoAparece = 0;

    foreach (var i in listaNumeros)
    {
        if (i == numeroEscolhido)
        {
            quantoAparece++;
        }
    }
    return quantoAparece;
}

static int[] MesclaEOrdena(int[] numero1, int[] numero2)
{
    int[] vetor3 = new int[numero1.Length + numero2.Length];

    for (int i = 0; i < numero1.Length; i++)
    {
        vetor3[i] = numero1[i];
    }
    for (int i = 0; i < numero2.Length; i++)
    {
        vetor3[i + numero1.Length] = numero2[i];
    }

    bool trocou;
    do
    {
        trocou = false;
        for (int i = 0; i < vetor3.Length - 1; i++)
        {
            if (vetor3[i] > vetor3[i + 1])
            {
                int auxTroca = vetor3[i];
                vetor3[i] = vetor3[i + 1];
                vetor3[i + 1] = auxTroca;
                trocou = true;
            }
        }
    } while (trocou);


    return vetor3;
}


static List<int> AdicionaValores1a5(List<int> listaPraAdicionar1a5)
{
    listaPraAdicionar1a5.Add(1);
    listaPraAdicionar1a5.Add(2);
    listaPraAdicionar1a5.Add(3);
    listaPraAdicionar1a5.Add(4);
    listaPraAdicionar1a5.Add(5);

    return listaPraAdicionar1a5;
}

static int EscreveERetornaSomaTotal(List<int> listaPraSomarValores)
{
    listaPraSomarValores.Add(int.Parse(Console.ReadLine()));
    listaPraSomarValores.Add(int.Parse(Console.ReadLine()));
    listaPraSomarValores.Add(int.Parse(Console.ReadLine()));
    listaPraSomarValores.Add(int.Parse(Console.ReadLine()));
    listaPraSomarValores.Add(int.Parse(Console.ReadLine()));

    int somaDosNumber = 0;
    foreach (int i in listaPraSomarValores)
    {
        somaDosNumber += i;
    }
    return somaDosNumber;
}

static int VoltaMaiorNumeroLista(List<int> listaSaberMaiorNumero)
{
    int auxMaiorDaLista = -5;
    foreach (int x in listaSaberMaiorNumero)
    {
        if (x > auxMaiorDaLista)
        {
            auxMaiorDaLista = x;
        }
    }
    return auxMaiorDaLista;
}

static List<string> RetirarFruta(List<string> listaFrutas)
{
    bool tamanhoListaFruta = true;
    string removerFruta;

    while (tamanhoListaFruta == true)
    {
        Console.WriteLine("Existe a lista de frutas: banana, maçã, uva e laranja.\nQual fruta você deseja remover da lista?");

        removerFruta = Console.ReadLine();

        if (listaFrutas.Contains(removerFruta))
        {
            listaFrutas.Remove(removerFruta);
            tamanhoListaFruta = false;
            Console.WriteLine($"Ok! Retirando a fruta {removerFruta}");
        }
        else
        {
            Console.WriteLine("Você não digitou corretamente a fruta que deseja excluir, por favor escreva certo.\n---------------------");
        }
    }
    return listaFrutas;
}

static string PrintLista(List<string> itens)
{
    return string.Join(",", itens) + ".";
}

static int QuantosMaioresQue50(List<int> ints)
{
    for (int i = ints.Count - 1; i >= 0; i--)
    {
        if (ints[i] < 51)
        {
            ints.Remove(ints[i]);
        }
    }
    int auxListaMaior50 = 0;
    foreach (int i in ints)
    {
        auxListaMaior50++;
    }
    return auxListaMaior50;
}

static bool ExisteONomeNaLista(string[] nomes, string chute)
{
    bool existeONome = false;
    foreach (string str in nomes)
    {
        if (str.Equals(chute, StringComparison.OrdinalIgnoreCase)) ;
        {
            existeONome = true;
        }
    }
    return existeONome;
}