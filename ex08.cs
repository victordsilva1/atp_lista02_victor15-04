/*Construa um programa que lê uma opção conforme abaixo (usar estrutura SWITCH) e o
salário atual do funcionário, calcula e exibe o novo salário:
A = aumento de 8% no salário;
B = aumento de 11% no salário;
C = aumento fixo no salário
(de R$ 350,00 se o salário atual for até R$ 1000 e de R$ 200,00 se o salário atual for
maior que R$ 1000).
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Escreva seu salário atual: ");   //User digita o salario atua
        int wage = int.Parse(Console.ReadLine()); //Converte e armazena

        Console.WriteLine("Digite: [A],[B] ou [C]"); //Usuario digita uma letra A , B , C 
        char escolha = char.Parse(Console.ReadLine()); //Converte e armazena char para o swtich

        double aumento = 0; //Variavel aumento
        double newWage;     //Variavel newWag, wage = salario english

        switch (escolha) //Switch case variavel escolha
        {
            case 'A':  //User digita A 
            case 'a':  //tambem coloquei minusculo o B e o C é o mesmo motivo  
                aumento = wage * 0.08; //Aumento de 8%
                newWage = aumento + wage; //Soma o aumento com o salario eda o novosalario
                Console.WriteLine("Aumento de " + aumento + "R$, seu novo salário é " + newWage + "R$"); //Exibe o aumento, e o novo salario
                break; //Quebra de switch
            case 'B':
            case 'b':
                aumento = wage * 0.11; //Aumento de 11%
                newWage = aumento + wage; //Soma o aumento com o salario eda o novosalario
                Console.WriteLine("Aumento de " + aumento + "R$, seu novo salário é " + newWage + "R$"); //Exibe o aumento, e o novo salario
                break;
            case 'C':
            case 'c':
                if (wage <= 1000) //se o salario for menor ou igual a 1000
                {
                    aumento = wage + 350; //soma 350
                    Console.WriteLine("Seu novo salário: " + aumento + "R$"); //e exibe o novo salario nesse caso deixei (aumento) mesmo
                }

          else if (wage > 1000) //Se o salario for maior que 1000
                {
                    aumento = wage + 200;//Soma 200
                    Console.WriteLine("Seu novo salário: " + aumento + "R$");//e exibe o novo salario nesse caso deixei (aumento) mesmo
                }
                break;


        default: //Caso o usuario não digite A , B ou C ou a,b ou c ele exibe opcao invalida
                Console.WriteLine("Opção inválida"); 
                return;
        }

        Console.ReadLine(); //So pra nao fechar a window
    }
}
