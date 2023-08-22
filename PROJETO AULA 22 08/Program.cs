// See https://aka.ms/new-console-template for more information

using PROJETO_AULA_22_08;

int num1 = 20;
int num2 = 11, result;

Somador soma;
soma = new Somador(); // instância em 2 linhas 

//Conversor conversor = new Conversor(); SE FOR ESTATICO (PUBLIC STATIC) NAO PRECISA INSTANCIAR
Conversor conversor = new Conversor();

double metros = 1.76;
result = soma.Soma(num1, num2);
   

Console.WriteLine($"A soma dos números {num1} e {num2} é {result}.");

Console.WriteLine($"A medida (0) metros corresponde a (1)", metros, Conversor.MetrosMilimetros(1.76));