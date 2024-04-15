/*Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for maior
ou igual a 10, some 5 a este número. Caso contrário some 7 a ele. Imprima o resultado
final.*/
using System;

class Program 
{
  public static void Main (string[] args) 
  {

int num1, num2, sum, sum10, sum7;

Console.WriteLine("Digite um número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro numero: ");
num2 = int.Parse(Console.ReadLine());

sum = num1 + num2;

Console.WriteLine("A soma dos dois é " + sum);

if (sum >= 10)
{
    sum10 = sum + 5;
    Console.WriteLine("O resultado somado com 5 é: " + sum10);
}
else 
{
    sum7 = sum + 7;
    Console.WriteLine("O resultado somado com 7 é: " + sum7);
}

Console.ReadLine();
  }
}  
