using System;

class Desafio15
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu peso em KG: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double IMC = peso / (altura * altura);

        Console.WriteLine($"Seu IMC é: {IMC:F2}");

        if (IMC < 18.5)
        {
            Console.WriteLine("Você está ABAIXO DO PESO!");
        }
        else if (IMC >= 18.5 && IMC <= 24.9)
        {
            Console.WriteLine("Você está no PESO IDEAL!");
        }
        else if (IMC >= 25 && IMC <= 29.9)
        {
            Console.WriteLine("Você está com SOBREPESO!");
        }
        else if (IMC >= 30 && IMC <= 34.9)
        {
            Console.WriteLine("Você está com OBESIDADE GRAU I");
        }
        else if (IMC >= 35 && IMC <= 39.9)
        {
            Console.WriteLine("Você está com OBESIDADE GRAU II");
        }
        else
        {
            Console.WriteLine("Você está com OBESIDADE GRAU III");
        }
    }
}
