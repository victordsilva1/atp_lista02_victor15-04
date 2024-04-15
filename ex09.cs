/* Fazer um programa para:
• Ler um símbolo do teclado;
• Identificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o
caso:
o "SINAL DE MENOR"
o "SINAL DE MAIOR"
o "SINAL DE IGUAL"
o "OUTRO SINAL"
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Digite um símbolo: "); //Usuario informa um simbolo
        char simb = char.Parse(Console.ReadLine()); //Armazena e converte em char

        switch (simb) 
        {
        case '<':  //Caso seja < exibir 
                Console.WriteLine("Sinal de Menor"); //Iso
                break; //Quebra
        case '>': //Caso seja > exibir
                Console.WriteLine("Sinal de Maior"); //Isso
                break;
        case '=': //Caso seja = exibir
                Console.WriteLine("Sinal de Igual"); //Isso
                break;
        default: //Caso nao seja nenhum desses 
                Console.WriteLine("Outro sinal"); //Exibir Outro Sinal 
                break;
        }
    }
}

