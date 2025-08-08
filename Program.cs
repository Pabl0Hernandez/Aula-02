using Aula_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando um Objeto");

        // Instanciando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";
        pessoa1.CPF = 123456789;
        pessoa1.DataNascimento = new DateOnly(1990, 1, 1);

        // Apresentando o objeto pessoal
        pessoa1.Apresetar();

        // Instanciando um objto da classe Pessoa com o construtor com Parâmetros
        Pessoa pessoa2 = new Pessoa("Maria", 987654321, new DateOnly(1995, 5, 15));
        pessoa2.Apresetar();

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Criando um Objeto Aluno Herdado de Pessoa");
        // Instanciando um objeto da classe Aluno
        Aluno aluno1 = new Aluno();
        // Atribuindo herdados da classe Pessoa
        aluno1.Nome = "Carlos";
        aluno1.CPF = 112233445;
        aluno1.DataNascimento = new DateOnly(2000, 3, 10);
        // Atributos da classe Aluno
        aluno1.Curso = "Engenharia";
        aluno1.Matricula = 2023001;

        // Apresentando o objeto aluno
        aluno1.Apresetar();

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Criando um Objeto Professor Herdado de Pessoa");

        // Instanciando um objeto da classe Professor
        Professor professor1 = new Professor();
        professor1.Nome = "Dr. Smith";
        professor1.CPF = 556677889;
        professor1.DataNascimento = new DateOnly(1975, 7, 20);
        professor1.Especialidade = "Matematica";
        professor1.Registro = 101;
        professor1.Salario = 5000;

        professor1.Apresetar();

        // Escapsulamento: é o principio de esconder os detalhes internos de um classe e expor apenas o necessario atraves de metodos publicos.
    }
}