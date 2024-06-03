using System;

class Desafio14
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine($"A raiz quadrada de {numero} é: {Math.Round(Math.Sqrt(numero), 2)}");
        }
        else
        {
            Console.WriteLine($"O quadrado de {numero} é: {Math.Pow(numero, 2)}");
        }
    }
}