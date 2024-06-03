using System;

    class Desafio6 
    {
        static void Main (string[] args) 
        {
            Console.WriteLine("Escreva o Ano: ");
            int anoDigitado = Convert.ToInt32(Console.ReadLine());

            if (anoDigitado % 4 == 0) {
                if (anoDigitado % 100 != 0) {
                    Console.WriteLine("O ano digitado é BISSEXTO");
                } else if (anoDigitado % 400 == 0) {
                     Console.WriteLine("O ano digitado é BISSEXTO");
                } else {
                    Console.WriteLine("O ano digitado não é BISSEXTO");
                }
            } else {
                Console.WriteLine("O ano digitado não é BISSEXTO");
            }
        }
    }

