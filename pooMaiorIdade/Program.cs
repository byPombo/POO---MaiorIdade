using System;
using System.Runtime.InteropServices;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determina qual é a pessoa mais velha");

            //Leitura de dados da 1ª pessoa.
            Console.WriteLine("Nome da 1ª pessoa: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1ª pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 2ª pessoa.
            Console.WriteLine("Nome da 2ª pessoa: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2ª pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de dados da 3ª pessoa.
            Console.WriteLine("Nome da 3ª pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade da 3ª pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            //Lógica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é : ");
                p1.ExibirDados();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é : ");
                    p2.ExibirDados();
                }
                else
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é : ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas tem a mesma idade.");
                    }
                }
            }

        }
    }
}
