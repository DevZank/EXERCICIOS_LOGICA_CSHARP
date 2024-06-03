using System;

    class Desafio7 
    {
        static void Main (string[] args) 
        {
            Console.Write("Escreva sua Idade: ");
            int Idade = Convert.ToInt32(Console.ReadLine());

            if (Idade >= 0 && Idade <= 12) {
                Console.Write("A idade informada é de uma Criança");
            } else if (Idade >= 13 && Idade <= 17) {
                Console.Write("A idade informada é de um Adolescente");
            } else if (Idade >= 18 && Idade <= 59) {
                Console.Write("A idade informada é de um Adulto");
            } else if (Idade > 60) {
                Console.Write("A idade informada é de um Idoso");
            } else {
                Console.Write("O número informado é negativo");
            }
        }
    }
