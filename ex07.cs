//Faça um programa para calcular e imprimir o valor de Y, dado um valor de X:


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de X:"); //Usuario digita o valor de x
        double x = double.Parse(Console.ReadLine()); //Armazena e converte
        double y; //VAriable y

        if (x <= 1) //Se x for menor ou igual a 1
        {
            y = 1; 
        }
      else if (x <= 2) //Se x for menor ou igual a 2
        {
            y = 2;
        }
      else if (x <= 3) //Se x for menor ou igual a 3
        {
            y = Math.Pow(x, 2); //Eleva ao quadrado 
        }
        else
        {
            y = Math.Pow(x, 3); //Eleva ao cubo
        }

        Console.WriteLine("O valor de Y é: " + y); //Exibe o y 
    }
}


