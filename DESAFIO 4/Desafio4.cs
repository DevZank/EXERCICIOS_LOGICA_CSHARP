using System;

    class Desafio4 
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Escreva o Lado A do Triangulo: ");
            int LadoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o Lado B do Triangulo: ");
            int LadoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o Lado C do Triangulo: ");
            int LadoC = Convert.ToInt32(Console.ReadLine());

            if (LadoA + LadoB > LadoC && LadoA + LadoC > LadoB && LadoB + LadoC > LadoA) {
                Console.WriteLine("Os Valores Informados Formam um Triãngulo");
            } else {
                Console.WriteLine("Os Valores Informados não Formam um Triãngulo");
            }
        }
    }