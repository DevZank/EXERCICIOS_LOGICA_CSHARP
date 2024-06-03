using System;

    class Desafio3 
    {
        static void Main (string[] args) 
        {
            Console.WriteLine("Escreva um Número: ");
            int numeroDigitado1 = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Escreva outro Número: ");
            int numeroDigitado2 = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine($"O maior número entre os Dois digitados é: {Math.Max(numeroDigitado1, numeroDigitado2)}");
        }
    }