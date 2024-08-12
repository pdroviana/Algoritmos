void Mensagem()
{
    Console.WriteLine("Olá mundo");
}

//Mensagem();

void Escreva(string msg)
{
    Console.WriteLine(msg);
}

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade} anos");
}


void CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}

CalcularIdade("Fulaninho", 2008);
CalcularIdade("Sicrano", 2010);

//exemplo

float resultado;

resultado = (2*100 + 3*50) / 2f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*70 + 3*50) / 2f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*99 + 3*33) / 2f;
Console.WriteLine("a média é: " + resultado);



void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){
    
    if(b == 0){
        Console.WriteLine("Erro de divisão por zero.");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//Variaveis Globais

float a;
float b;

void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    Console.WriteLine("Digite o valor de a: ");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de b: ");
    b = float.Parse(Console.ReadLine());
}

//MENU
Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("------------------");
Console.WriteLine("Digite a opção desejada:");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
}
else if(opcao == 5){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine("Opção inválida");
}

