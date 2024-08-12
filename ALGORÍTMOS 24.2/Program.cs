/*Console.WriteLine("Digite seu nome");

string nome = Console.ReadLine();

Console.WriteLine("Salve, " + nome + ", digite o valor de a");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o valor de b");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("A soma de a e b é: " + (a + b));

using System.ComponentModel;

Console.WriteLine("Digite um número");

int n = int.Parse(Console.ReadLine());

bool par = n % 2 == 0;

if(par)
{
  Console.WriteLine("É par");
}/
else
{
  Console.WriteLine("Não é par");
}


string senha = "4321";
Console.WriteLine("Digite a senha");
string senha_digitada = Console.ReadLine();

if(senha == senha_digitada)
{
    Console.WriteLine("Senha correta. Entrou.");
}
else
{
    Console.WriteLine("Senha incorreta");
}*/

Console.WriteLine("Digite uma nota");
int nota = int.Parse(Console.ReadLine());

if(nota >= 60)
{
    Console.WriteLine("Aprovado");
}
else if(nota >= 20)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");/
}