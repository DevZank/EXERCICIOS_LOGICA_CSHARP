using System;

class Desafio10
{
   static void Main(string[] args)
   {
      Console.WriteLine("Digite um número: ");
      double numero1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite outro número: ");
      double numero2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("===================================");
      Console.WriteLine("ESCOLHA UMA OPERAÇÃO: ");
      Console.WriteLine("ESCREVA ' + ' PARA ADIÇÃO");
      Console.WriteLine("ESCREVA ' - ' PARA SUBTRAÇÃO");
      Console.WriteLine("ESCREVA ' * ' PARA MULTIPLICAÇÃO");
      Console.WriteLine("ESCREVA ' / ' PARA DIVISÃO");
      string operacao = Console.ReadLine();
      Console.WriteLine("===================================");

      if (operacao == "+")
      {
         Console.WriteLine($"A Soma dos  dois valores é: {numero1 + numero2}");
      }
      else if (operacao == "-")
      {
         Console.WriteLine($"A Subtração dos dois valores é: {numero1 - numero2}");
      }
      else if (operacao == "*")
      {
         Console.WriteLine($"A Multiplicação dos dois valores é: {numero1 * numero2}");
      }
      else if (operacao == "/")
      {
         Console.WriteLine($"A Divisão dos dois valores é: {numero1 / numero2}");
      }
      else
      {
         Console.WriteLine("Operação Invalida");
      }
   }
}