using System;

class Desafio9
{
    static void Main (string[] args)
    {
        Console.WriteLine("Escreva o código de um Produto: ");
        int codigoDoProduto = Convert.ToInt32(Console.ReadLine());

        if (codigoDoProduto >= 1 && codigoDoProduto <= 10)
        {
            Console.WriteLine("O Produto informado é um Alimento não-perecível");
        } 
        else if (codigoDoProduto >= 11 && codigoDoProduto <= 20)
        {
            Console.WriteLine("O Produto informado é um Alimento perecível");
        } 
        else if (codigoDoProduto >= 21 && codigoDoProduto <= 30)
        {
            Console.WriteLine("O Produto informado é do Vestuário");
        } 
        else if (codigoDoProduto >= 31 && codigoDoProduto <= 40)
        {
            Console.WriteLine("O Produto informado é um Eletrônico");
        } 
        else
        {
            Console.WriteLine("Código inválido");
        }
    }
}