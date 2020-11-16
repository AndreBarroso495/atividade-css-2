using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nascimento :");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o ano atual!");
            int anoAtual = int.Parse(Console.ReadLine());
            int idade = (anoAtual - anoDeNascimento);
            int semanas = (idade * 52);
            Console.WriteLine("idade em anos :" +idade);
            Console.WriteLine("idade em semanas :"+semanas);
            
        }
    }
}
