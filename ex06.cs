/* m hotel com 75 apartamentos deseja fazer uma promoção especial de final de semana,
concedendo um desconto de 25% na diária. Com isso, espera aumentar sua taxa de
ocupação de 50% para 80%. Sendo dado o valor normal da diária, calcular e imprimir:*/


using System;

class Program
{
    static void Main(string[] args)
    {
        int totalApartamentos = 75;
        double ocupacaoNormal = 0.5;
        double ocupacaoPromocional = 0.8;

        Console.WriteLine("Digite o valor normal da diária:");
        double valorDiariaNormal = double.Parse(Console.ReadLine());

        // a) Calcular o valor da diária promocional
        double desconto = 0.25; // 25%
        double valorDiariaPromocional = valorDiariaNormal * (1 - desconto);

        // b) Calcular o valor total arrecadado com 80% de ocupação e diária promocional
        int apartamentosOcupadosPromocional = (int)(totalApartamentos * ocupacaoPromocional);
        double valorTotalPromocional = apartamentosOcupadosPromocional * valorDiariaPromocional;

        // c) Calcular o valor total arrecadado com 50% de ocupação e diária normal
        int apartamentosOcupadosNormal = (int)(totalApartamentos * ocupacaoNormal);
        double valorTotalNormal = apartamentosOcupadosNormal * valorDiariaNormal;

        // d) Calcular a diferença entre esses dois valores
        double diferenca = valorTotalPromocional - valorTotalNormal;

        Console.WriteLine("a) O valor da diária promocional é: " + valorDiariaPromocional.ToString("C2"));
        Console.WriteLine("b) O valor total arrecadado com 80% de ocupação e diária promocional é: " + valorTotalPromocional.ToString("C2"));
        Console.WriteLine("c) O valor total arrecadado com 50% de ocupação e diária normal é: " + valorTotalNormal.ToString("C2"));
        Console.WriteLine("d) A diferença entre esses dois valores é: " + diferenca.ToString("C2"));
    }
}
