//Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0),
//calcular e escrever a raiz da equação

using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite sua nota: "); //Usuario digita a nota
        double note = double.Parse(Console.ReadLine()); //Converte de string para double

        if (note > 10 | note < 0) //Se a nota for maior que 10 ou menor que 0, mostra que a nota é invalid
        {
            Console.WriteLine("Invalid Note");

        }

        else if (note >= 8 && note <= 10) //Se a nota for maior ou igual a 8 e menor ou igual a 10, mostra Otimo
        {
            Console.WriteLine("Otimo");

        }
        else if (note >= 7 && note < 8)  //Se a nota for maior ou igual a 7 e menor que 8, mostra Bom
        {
            Console.WriteLine("Bom");

        }
        else if (note >= 5 && note < 7) //Se anota for maior ou = a 5 e menor que 7 . mostra Regular
        {
            Console.WriteLine("Regular");
        }
        else if (note < 5) //Se a nota for menor que 5,mostra insatisfatorio
        {
            Console.WriteLine("Insatisfatorio");
        }
        else
        {
            Console.WriteLine("Invalid Note"); //Caso tudo isso nao ocorra essa nota é invalid
        }

        Console.ReadLine(); //So para nao dar exit

    }
}
