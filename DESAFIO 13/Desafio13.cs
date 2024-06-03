using System;

class Desafio13
{
    static void Main(string[] args)
    {
        Console.Write("Digite o Valor da Compra: R$");
        double valorDaCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("=================================");
        Console.WriteLine("Digite a Categoria do Cliente:");
        Console.WriteLine("INFORME ' 1 ' PARA COMUM");
        Console.WriteLine("INFORME ' 2 ' PARA ASSOCIADO");
        Console.WriteLine("INFORME ' 3 ' PARA VIP");
        int categoriaCliente = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("=================================");
        Console.WriteLine("");

        if (categoriaCliente == 1)
        {
            Console.WriteLine($"O Valor final da compra não foi alterado TOTAL A PAGAR: R${valorDaCompra}");
        }
        else if (categoriaCliente == 2)
        {
            Console.WriteLine($"O Valor final da compra foi alterado TOTAL A PAGAR: R${valorDaCompra - valorDaCompra * 0.1}");
        }
        else if (categoriaCliente == 3)
        {
            Console.WriteLine($"O Valor final da compra foi alterado TOTAL A PAGAR: R${valorDaCompra - valorDaCompra * 0.2}");
        }
        else
        {
            Console.WriteLine("ERRO! Categoria do Cliente INVALIDA");
        }
    }
}