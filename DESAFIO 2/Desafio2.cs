using System;

    class Desafio2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Escreva um Número: ");
            double numeroDigitado = Convert.ToDouble(Console.ReadLine());
            if (numeroDigitado > 0) {
                Console.WriteLine($"O Número {numeroDigitado} é POSITIVO");
            }  else if (numeroDigitado < 0) {
                Console.WriteLine($"O Número {numeroDigitado} é NEGATIVO");
            } else {
                Console.WriteLine($"O Número {numeroDigitado} é ZERO");
            }
        }
    }
