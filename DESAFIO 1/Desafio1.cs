using System;

class Desafio1 
{
        static void Main (string[] args) 
        {
            Console.WriteLine("Escreva um Número: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 == 0) {
                Console.WriteLine("O número digitado é PAR!");
            } else {
                Console.WriteLine("O número digitado é IMPAR!");
            }
        }
}
