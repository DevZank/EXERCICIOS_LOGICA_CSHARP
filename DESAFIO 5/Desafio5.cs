using System;

    class Desafio5 
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Escreva a 1ª Nota: ");
            double Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a 2ª Nota: ");
            double Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a 3ª Nota: ");
            double Nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (Nota1 + Nota2 + Nota3) / 3;

            if (media >= 7) {
                Console.WriteLine("O Aluno foi APROVADO");
            } else if (media >= 5 && media < 7) {
                Console.WriteLine("O Aluno está em RECUPERAÇÃO");
            } else {
                Console.WriteLine("O Aluno foi REPROVADO");
            }
        }
    }
