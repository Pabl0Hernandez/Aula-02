using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    public class Pessoa
    {
        // Atributos da Classe Pessoa
        public string? Nome { get; set; }
        public int? CPF { get; set; }
        public DateOnly? DataNascimento { get; set; }

        public Pessoa() { }

        // Metodo da Classe Pessoa 
        public virtual void Apresetar() // Metodo virtual para permitir sobrescrita em classes derivadas
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu CPF é {CPF} e minha data de nascimento é {DataNascimento}");
        }

        // Construtor da Classe Pessoa
        public Pessoa(string nome, int cpf, DateOnly dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }
    }
}
