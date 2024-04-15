//Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0),
//calcular e escrever a raiz da equação
using System;

class Program 
{
  public static void Main (string[] args) 
  {

    Console.WriteLine("Digite o coeficiente 'a': "); //Usuario digita o coefince a 
    double a = Convert.ToDouble(Console.ReadLine()); //Converte de string para double 

    Console.WriteLine("Digite o coeficiente 'b': "); //Usuraio digita o coeficiente b
    double b = Convert.ToDouble(Console.ReadLine()); //Converte novamente

    if (a != 0) //Se o (a) for diferente de 0 ele vai calcular a raiz e exibir o resultado
    {
        double raiz = (-b / a); //Essa é a formula para calcular a raiz 
        Console.WriteLine("A raiz da equacao é: " + raiz); //Exibila 
    }
    else
    {
        Console.WriteLine("Essa equacao não é do 1 grau "); //Caso o (a) = 0 , essa equacao nao é do 1 grau 

    }
    Console.ReadLine(); //So pra nao fechar a janela

    }
  }
