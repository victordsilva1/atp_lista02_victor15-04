using System;

class Program
{
    public static void Main(string[] args)
    {

        int anoNascimento;
        char fezAniversario;

        Console.Write("Digite o ano de nascimento: "); //Usuario digita ano de nascimento 
        anoNascimento = int.Parse(Console.ReadLine()); //Converte

        Console.Write("Já fez aniversário neste ano? (S/N): "); //Usuario digita se fez aniversario
        fezAniversario = char.ToUpper(Console.ReadLine()[0]); //deixa S e N em minusculo tambem aceito

        int idade = 2024 - anoNascimento; //Pega a idade inserida pelo usuario e subtrai do ano atual
        if (fezAniversario == 'N') //Se fez aniversario for N, subtrai 1 da idade
        {
            idade--;
        }

        Console.WriteLine("Sua idade é: " + idade); //Mostra a idade

        if (idade >= 18) //Se a idade for maior ou igual a 18, mostra que pode tirar carteira
        {
            Console.WriteLine("Você já tem idade tirar carteira de motorista");
        }
        else  //Se a idade for menor que 18, mostra que não pode tirar carteira
        {
            Console.WriteLine("Você ainda não tem idade para tirar carteira de motorista");
        }
        Console.ReadKey(); //Janela open

    }
}

