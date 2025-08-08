using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    public class Professor : Pessoa
    {
        public string Especialidade { get; set; }
        public int Registro { get; set; }
        public double Salario { get; set; }

        // Sobregarga do método Apresetar da classe Pessoa (Polimorfismo)
        public override void Apresetar()
        {
            base.Apresetar(); // Chama o método Apresetar da classe base Pessoa
            Console.WriteLine($"sou especialista em {Especialidade} meu registro é {Registro} e meu salario é {Salario}."); // Adiciona informações específicas do Professor
        }
    }
}