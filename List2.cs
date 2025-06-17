//Lista 02 - Lógica de Programação - Estruturas de Seleção
//Exercícios condição simples (if).
//1.Escreva um programa que verifique se um número é positivo ou negativo e exiba uma mensagem correspondente.
Console.WriteLine("Escreva um número");
double numPosNeg = double.Parse(Console.ReadLine());
if (numPosNeg > 0)
{
    Console.WriteLine("o número é positivo");
}
else if (numPosNeg == 0)
{
    Console.WriteLine("o número é nulo");
}
if (numPosNeg < 0)
{
    Console.WriteLine("o número é negativo");
}


////2.Crie um programa que determine se um usuário é maior de idade (idade igual ou acima de 18 anos) e exiba uma mensagem apropriada.
Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());
if (idade >= 18)
    Console.WriteLine("Você é maior de idade no Brasil");
if (idade < 18)
    Console.WriteLine("Você não é maior de idade no Brasil");


//3.Desenvolva um programa que verifique se um número é par ou ímpar e exiba o resultado.
Console.WriteLine("Escreva um número inteiro");
double numParImpar = double.Parse(Console.ReadLine());
if (numParImpar % 2 == 0)
    Console.WriteLine("O número é par.");
if (numParImpar % 2 != 0)
    Console.WriteLine("O número é ímpar.");


//4.Faça um programa que determine se um aluno passou em um exame, considerando que a nota mínima para aprovação é 60.
Console.WriteLine("Informe a nota do launo em forma centesimal");
double notaAprovacao = double.Parse(Console.ReadLine());
if (notaAprovacao >= 60)
    Console.WriteLine("Você foi aprovado");
if (notaAprovacao < 60)
    Console.WriteLine("Você está reprovado");


//5.Escreva um programa que verifique se um número digitado pelo usuário é múltiplo de 5.
Console.WriteLine("Informe um número");
double numDiv5 = double.Parse(Console.ReadLine());
if (numDiv5 % 5 == 0)
    Console.WriteLine("Esse número é divisível por 5");
if (numDiv5 % 5 != 0)
    Console.WriteLine("Esse número não é divisível por 5");


//-----------------
//------------------------------
//-----------------


//Exercícios condição composta(if-else).
//1.Crie um programa que, dado o peso e a altura de uma pessoa, determine se ela está abaixo do peso, com peso normal, com sobrepeso ou obesa, de acordo com o índice de massa corporal (IMC).
Console.WriteLine("Informe sua altura em metros, usando a vírgula");
double alturaM = double.Parse(s: Console.ReadLine());
Console.WriteLine("Informe seu peso em kilogramas");
double pesoKG = double.Parse(s: Console.ReadLine());
double imc = (pesoKG / alturaM) / alturaM;

if (imc < 18.5)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está abaixo do peso");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está na faixa de peso ideal");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está com sobrepeso");
}
else if (imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está com obesidade grau I");
}
else if (imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está com obesidade grau II");
}
else if (imc >= 40)
{
    Console.WriteLine($"O seu IMC é {imc}, e isso indica que você está com obesidade grau III");
}


//2.Desenvolva um programa que determine se um ano é bissexto ou não. Um ano é bissexto se for divisível por 4, mas não por 100, a menos que seja divisível por 400.
Console.WriteLine("Qual ano você quer saber se é bissexto ou não?");
int anoB6 = int.Parse(Console.ReadLine());
if (anoB6 % 4 == 0 && anoB6 % 100 != 0 || anoB6 % 400 == 0)
{
    Console.WriteLine("Esse ano é bissexto");
}
else
{
    Console.WriteLine("Esse ano não é bissexto");
}


//3.Faça um programa que determine o maior de três números digitados pelo usuário.
Console.WriteLine("Escreva seu primeiro número");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva seu segundo número");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva seu terceiro número");
double num3 = double.Parse(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"O seu primeiro número, {num1}, é o maior dentre os três");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"O seu segundo número, {num2}, é o maior dentre os três");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"O seu terceiro número, {num3}, é o maior dentre os três");
}
else if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("Seus três números são iguais, então todos são o maior número dentre os três");
}
else
{
    Console.WriteLine("Dois números seus são iguais, e ambos são o maior número dentre os três");
}


//4.Escreva um programa que calcule o preço de um produto com desconto de 10% se o valor total da compra for maior ou igual a R$100.
Console.WriteLine("Valor total da compra foi (digite apenas o número de reais):");
double precoFinal = double.Parse(Console.ReadLine());
if (precoFinal < 100)
{
    Console.WriteLine($"Obrigado pela compra! Pode pagar os R${precoFinal}.");
}
else
{
    double precoDesconto = precoFinal - (precoFinal / 10);
    Console.WriteLine($"Obrigado pela compra, você teve um desconto de 10%, agora sua compra deu R${precoDesconto}.");

}


//5.Crie um programa que solicite o nome e a idade de um usuário e, com base na idade, apresente mensagens de boas-vindas apropriadas: "Bem-vindo, [Nome]!" para idades até 12 anos, "Olá, [Nome]!" para idades entre 13 e 19 anos, e "Olá, Sr./Sra. [Nome]!" para idades acima de 19 anos.
Console.WriteLine("Por favor, informe seu nome.");
string nome5de2 = Console.ReadLine();
Console.WriteLine("Por favor, informe sua idade.");
int idade5de2 = int.Parse(Console.ReadLine());
if (idade5de2 < 13)
{
    Console.WriteLine($"Bem-vindo, {nome5de2}!");
}
else if (idade5de2 > 12 && idade5de2 < 19)
{
    Console.WriteLine($"Olá, {nome5de2}!");
}
else
{
    Console.WriteLine($"Olá, Sr./Sra. {nome5de2}!");
}


//-----------------
//------------------------------
//-----------------


//Exercícios operadores lógicos
//1. Crie um programa que verifique se um número digitado pelo usuário é positivo, negativo ou zero. Imprima a mensagem correspondente.
Console.WriteLine("Informe um número.");
double numUsuario1de3 = double.Parse(Console.ReadLine());
if (numUsuario1de3 < 0) //usando operador lógico??
    Console.WriteLine("O número informado é negativo.");
else if (numUsuario1de3 > 0)
    Console.WriteLine("O número informado é positivo.");
else Console.WriteLine("O número informado é o 0, nulo.");


//2.Desenvolva um programa que pergunte ao usuário se deseja um café. Se o usuário digitar "sim", pergunte se ele quer açúcar. Com base nas respostas, exiba uma mensagem adequada, como "Aqui está o seu café preto." ou "Aqui está o seu café com açúcar."
Console.WriteLine("Gostaria de um café? Sim ou não?");
string respostaCafe = Console.ReadLine();
string respostaCafeSim = "sim";
string respostaCafeNao = "não";
if (respostaCafe.Equals(respostaCafeNao))
{
    Console.WriteLine("Ok. Tchau.");
}
else if (respostaCafe.Equals(respostaCafeSim))
{
    Console.WriteLine("Gostaria de açúcar no seu café?");
    string respostaAcucar = Console.ReadLine();
    string respostaAcucarSim = "sim";
    string respostaAcucarNao = "não";
}


//3 - Crie um programa que peça ao usuário para digitar três números inteiros. Verifique se pelo menos dois dos números são iguais entre si. Se sim, imprima "Pelo menos dois números são iguais", caso contrário, imprima "Nenhum dos números é igual aos outros."
Console.WriteLine("Escreva seu primeiro número inteiro"); //como digitar espaçando tres numeros e o pc ententender q são 3 números e variaveis difererntes?
int numInteiro1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva seu segundo número inteiro");
int numInteiro2 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva seu terceiro número inteiro");
int numInteiro3 = int.Parse(Console.ReadLine());
if (numInteiro1 == numInteiro2 && numInteiro2 == numInteiro3)
{
    Console.WriteLine("Os seus três números são iguais");
}
else if ((numInteiro1 == numInteiro2 && numInteiro1 != numInteiro3) || (numInteiro2 == numInteiro3 && numInteiro2 != numInteiro1) || (numInteiro1 == numInteiro3 && numInteiro1 != numInteiro2))
{
    Console.WriteLine("Dois de seus números são iguais");
}
else Console.WriteLine("Os seus três números são diferentes");


//4.Escreva um programa que simule um caixa eletrônico. Peça ao usuário para digitar o saldo da conta e o valor que deseja sacar. Verifique se há saldo suficiente na conta. Se houver, imprima "Saque autorizado." Se não houver saldo suficiente, imprima "Saldo insuficiente."
Console.WriteLine("Qual é o seu saldo atual no banco?");
double saldoAtual = double.Parse(Console.ReadLine());
Console.WriteLine("E quanto você quer sacar?");
double sacarAgora = double.Parse(Console.ReadLine());
if (saldoAtual >= sacarAgora)
{
    Console.WriteLine($"Saque de R${sacarAgora} sendo liberado. Aguarde");
}
else if (saldoAtual < sacarAgora)           
{
    Console.WriteLine("Saldo insuficiente.");
}


//5.Crie um programa que simule um sistema de controle de acesso a um edifício. Peça ao usuário para digitar sua identificação e a hora de entrada. O acesso é permitido apenas se a identificação for válida (por exemplo, "12345") e se a hora de entrada estiver entre 9h e 18h. Imprima uma mensagem informando se o acesso foi autorizado ou negado.
Console.WriteLine("Hora atual? Escreva apenas a hora cheia");
int horaAtual = int.Parse(Console.ReadLine());

if (horaAtual >= 9 && horaAtual <= 18)
{
    Console.WriteLine("Você não chegou dentro do toque de recolher permitido, que é entre 9h e 18h. Entrada não permitida.");
}

Console.WriteLine("Senha de autenticação");
int senhaAutenticacao = int.Parse(Console.ReadLine());

if (senhaAutenticacao == 12345)
{
    Console.WriteLine("Entrada permitida.");
}
else Console.WriteLine("Senha incorreta.");


//-----------------
//------------------------------
//-----------------


//Exercícios Switch Case
//1.Calculadora Simples: Crie uma calculadora simples que solicite ao usuário dois números e um operador (+, -, *, /). Use switch case para realizar a operação escolhida e mostrar o resultado.
Console.WriteLine("Escreva um número.");
float num1Calcula = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva outro número.");
float num2Calcula = float.Parse(Console.ReadLine());
Console.WriteLine("Escolha agora a operação.");
Console.WriteLine("Digite 1 para aplicar a adição.");
Console.WriteLine("Digite 2 para aplicar a subtração.");
Console.WriteLine("Digite 3 para aplicar a multiplicação.");
Console.WriteLine("Digite 4 para aplicar a divisão.");
string modoCalcula = Console.ReadLine();

switch (modoCalcula)
{
    case "1":
        float respostaCalcula1 = num1Calcula + num2Calcula;
        Console.WriteLine($"Resultado: {respostaCalcula1}.");
        break;

    case "2":
        float respostaCalcula2 = num1Calcula - num2Calcula;
        Console.WriteLine($"Resultado: {respostaCalcula2}.");
        break;


    case "3":
        float respostaCalcula3 = num1Calcula * num2Calcula;
        Console.WriteLine($"Resultado: {respostaCalcula3}.");
        break;

    case "4":
        float respostaCalcula4 = num1Calcula / num2Calcula;
        Console.WriteLine($"Resultado: {respostaCalcula4}.");
        break;
}


//2.Conversão de Unidades: Crie um conversor de unidades que permita ao usuário escolher entre converter uma quantidade em metros para centímetros ou centímetros para metros usando switch case.
Console.WriteLine("Escreva uma quatia, se for em metros com número decimal, divida com o ponto \".\" .");
double medidaInicial = double.Parse(Console.ReadLine());
Console.WriteLine("Você quer converter essa medida para centímetros ou metros?");
Console.WriteLine("Digite 1 para converter para centímetros");
Console.WriteLine("Digite 2 para converter para metros");
string respostaConversao = Console.ReadLine();

switch (respostaConversao)
{
    case "1":
        double medidaCent = medidaInicial * 100;
        Console.WriteLine($"A medida convertida fica {medidaCent} centímetros.");
        break;

    case "2":
        double medidaMetros = medidaInicial / 100;
        Console.WriteLine($"A medida convertida fica {medidaMetros} metros.");
        break;

    default:
        Console.WriteLine("Digite uma conversão disponível.");
        break;
}


//3. Seleção de Língua: Desenvolva um programa multilíngue que solicite ao usuário que escolha um idioma (1 para inglês, 2 para espanhol, 3 para francês) e exiba uma saudação de boas-vindas nesse idioma usando switch case. Se o idioma escolhido não estiver disponível, exiba uma mensagem informando que o idioma é inválido.
Console.WriteLine("Selecione o idioma do site.");
Console.WriteLine("Digite 1 para inglês.");
Console.WriteLine("Digite 2 para espanhol.");
Console.WriteLine("Digite 3 para francês.");
int temp = 0;
while (temp == 0)
{
    string modoIdioma = Console.ReadLine();

    switch (modoIdioma)
    {
        case "1":
            Console.WriteLine("Welcome to our website!");
            temp = 1;
            break;

        case "2":
            Console.WriteLine("Bienvenido a nuestro sitio web!");
            temp = 1;
            break;

        case "3":
            Console.WriteLine("Bienvenue sur notre site!");
            temp = 1;
            break;

        default:
            Console.WriteLine("Idioma é inválido. Tente alguma opção válida.");
            break;
    }
}


//4.Conversão de Meses: Desenvolva um conversor de meses que solicite ao usuário um número de 1 a 12, representando um mês do ano. Use switch case para exibir o nome do mês correspondente. Se o número estiver fora do intervalo, mostre uma mensagem de erro.
Console.WriteLine("Escreva o número do mês que deseja acessar.");
string mesNumero = Console.ReadLine();
switch (mesNumero)
{
    case "1":
        Console.WriteLine("Acessado o mês de Janeiro.");
        break;

        ;
    case "2":
        Console.WriteLine("Acessado o mês de Fevereiro.");
        break;

    case "3":
        Console.WriteLine("Acessado o mês de Março.");
        break;

    case "4":
        Console.WriteLine("Acessado o mês de Abril.");
        break;

        ;
    case "5":
        Console.WriteLine("Acessado o mês de Maio.");
        break;

    case "6":
        Console.WriteLine("Acessado o mês de Junho.");
        break;

    case "7":
        Console.WriteLine("Acessado o mês de Julho.");
        break;

        ;
    case "8":
        Console.WriteLine("Acessado o mês de Agosto.");
        break;

    case "9":
        Console.WriteLine("Acessado o mês de Setembro.");
        break;

    case "10":
        Console.WriteLine("Acessado o mês de Outubro.");
        break;

    case "11":
        Console.WriteLine("Acessado o mês de Novembro.");
        break;

    case "12":
        Console.WriteLine("Acessado o mês de Dezembro.");
        break;

    default:
        Console.WriteLine("Número de mês errado. Coloque um número válido.");
        break;
}


//-----------------
//------------------------------
//-----------------


//Exercícios Operador Ternário
//1. Verificação de Paridade: Escreva uma função chamada VerificarParidade que recebe um número inteiro como argumento e retorna uma string "Par" se o número for par e "Ímpar" se for ímpar.
Console.WriteLine("Escreva um número inteiro.");
int numParImpar5e1 = int.Parse(Console.ReadLine());
string statusNum5e1 = (numParImpar5e1 % 2 == 0) ? "O número é par." : "O número é ímpar.";
Console.WriteLine(statusNum5e1);


//2.Calculadora de Desconto: Crie uma função chamada CalcularDesconto que recebe o preço de um produto e um booleano indicando se o cliente é um membro VIP. Se o cliente for VIP, o desconto é de 20%; caso contrário, o desconto é de 10%. A função deve retornar o preço com o desconto aplicado.
Console.WriteLine("Qual o preço do produto?");
double precoProduto = double.Parse(Console.ReadLine());
Console.WriteLine("Você é membro VIP? \"Sim\" ou \"Não\"");
bool membroVIP = Console.ReadLine() == "Sim";
double CalcularDesconto = (membroVIP) ? precoProduto * 0.8 : precoProduto * 0.9;
Console.WriteLine(CalcularDesconto);


//3.Classificação de Aluno: Crie um programa que solicita ao usuário a nota de um aluno e determine se ele foi aprovado ou reprovado. Use o operador ternário para definir a aprovação com base na nota (por exemplo, notas maiores ou iguais a 6 são aprovadas).
Console.WriteLine("Qual foi a média do aluno? de 0 a 10.");
float mediaAluno = float.Parse(Console.ReadLine());
string statusMedia5e2 = (mediaAluno >= 6) ? "O aluno está aprovado." : "O aluno está reprovado.";
Console.WriteLine(statusMedia5e2);


//4.Avaliação de Idade: Crie uma função chamada ClassificarIdade que recebe a idade de uma pessoa como argumento e retorna uma string indicando se a pessoa é uma "Criança" (até 12 anos), "Adolescente" (de 13 a 19 anos) ou "Adulto" (20 anos ou mais).
Console.WriteLine("Digite sua idade.");
int ClassificarIdade = int.Parse(Console.ReadLine());
string statusIdade = (ClassificarIdade >= 20) ? "Adulto." : (ClassificarIdade <= 12) ? "Criança." : "Adolescente.";
Console.WriteLine(statusIdade);