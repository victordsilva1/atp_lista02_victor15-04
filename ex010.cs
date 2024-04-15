/*Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista
estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a
mensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade
máxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os
valores a serem cobrados são os seguintes:
• 50 reais se o motorista ultrapassar em até 10km/h a velocidade permitida (ex: se a
velocidade máxima for 50km/h e o motorista estiver a 60km/h ou a 56km/h);
• 100 reais, se o motorista ultrapassar de 11km/h a 30km/h a velocidade permitida;
• 200 reais, se estiver acima de 30km/h da velocidade permitida.
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite a velocidade maxima permitida em (km/h): "); //User ensere a velocidade maxima permitida
        int permitted = Convert.ToInt32(Console.ReadLine());//Converte e armazena 

        Console.WriteLine("Digite a velocidade que aquele `rachador` passou em (km/h): "); //User coloca a velocidade que passou o veiculo
        int passed = Convert.ToInt32(Console.ReadLine());//Converte e armazena 

        if (passed <= permitted) //Se a velocidade passada for menor ou igual a velocidade permitida
        {
            Console.WriteLine("Dentro da lei"); //Escreve dentro da lei
        }
      else //Caso não
        {
            int diferrence = passed - permitted; //Nova variavel difença

            if (diferrence <= 10) //se a diferença for menor ou igual a 10
            {
                Console.WriteLine("Multa de 50 R$ por ultrapassar " + diferrence + " Km/h");
            }
          else if (diferrence <= 30) //se não se a diferença for menor ou igual a 30
            {
                Console.WriteLine("Multa de 100 R$ por ultrapassar " + diferrence + " Km/h");
            }
          else //Caso contrario multa 200R$
            {
                Console.WriteLine(" Multa de 200R$ você é um `rachador` ");
            }

          
        }
      
        Console.ReadLine(); //So pra nao fechar a window
    }
}

