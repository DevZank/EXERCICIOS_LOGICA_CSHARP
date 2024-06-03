using System;

class Desafio11
{
    static void Main(string[] args)
    {
        Console.Write("Escreva um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
        {
            Console.WriteLine("O numero está no Intervalo de 10 a 20");
        }
        else
        {
            Console.WriteLine("O numero não está no Intervalo de 10 a 20");
        }
    }
}