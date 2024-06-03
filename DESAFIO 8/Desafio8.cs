using System;

class Desafio8 
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite a Nota do Aluno: ");
        int notaDoAluno = Convert.ToInt32(Console.ReadLine());

        if (notaDoAluno >= 9 && notaDoAluno <= 10) 
        {
            Console.WriteLine("A nota conceito do aluno é A");
        }
        else if (notaDoAluno >= 7 && notaDoAluno < 9)
        {
            Console.WriteLine("A nota conceito do aluno é B");
        }
        else if (notaDoAluno >= 5 && notaDoAluno < 7)
        {
            Console.WriteLine("A nota conceito do aluno é C");
        }
        else if (notaDoAluno >= 3 && notaDoAluno < 5)
        {
            Console.WriteLine("A nota conceito do aluno é D");
        }
         else if (notaDoAluno >= 0 && notaDoAluno < 3)
        {
            Console.WriteLine("A nota conceito do aluno é D");
        }
        else 
        {
            Console.WriteLine("A nota é INVALIDA!");        
        }
    }
}