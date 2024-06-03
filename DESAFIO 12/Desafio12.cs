using System;

class Desafio12
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 100)
        {
            Console.WriteLine("O número informado é maoir a 100");
        }
        else
        {
            Console.WriteLine($"O número por não ser maior que 100 será dobrado agora ele tem o valor de: {numero * 2}");
        }
    }
}