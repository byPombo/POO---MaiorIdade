using System;
using System.Collections.Generic;
using System.Text;

namespace pooMaiorIdade
{
    public class Pessoa
    {
        //Construtores
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        //Propriedades
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;
        public int Idade
        {
            get{return idade;}
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }
            }
        }
        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Nome: " + this.Idade);
        }
    }
}
