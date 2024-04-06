namespace SCA_PB_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criando curso
            Curso curso = new Curso(1, "Ciência da Computação");

            // Criando grade
            Grade grade = new Grade();

            // Criando disciplinas
            Disciplina disciplina1 = new Disciplina(1, "Programação I");
            Disciplina disciplina2 = new Disciplina(2, "Matemática Discreta");
            Disciplina disciplina3 = new Disciplina(3, "Sistemas Operacionais");

            // Adicionando disciplinas à grade
            grade.AddDisciplina(disciplina1);
            grade.AddDisciplina(disciplina2);
            grade.AddDisciplina(disciplina3);

            // Atribuindo grade ao curso
            curso.Grade = grade;

            // Criando alunos
            Aluno aluno1 = new Aluno(10101, "André");
            Aluno aluno2 = new Aluno(10102, "Lucas");
            Aluno aluno3 = new Aluno(10103, "Pedro");
            Aluno aluno4 = new Aluno(10104, "João");
            Aluno aluno5 = new Aluno(10105, "Maria");

            // Adicionando alunos ao curso
            curso.AddAluno(aluno1);
            curso.AddAluno(aluno2);
            curso.AddAluno(aluno3);
            curso.AddAluno(aluno4);
            curso.AddAluno(aluno5);

            // Imprimindo os 5 alunos adicionados
            Console.WriteLine("Os 5 alunos adicionados testando o método AddAlunos da classe Curso:");
            Console.WriteLine($"1. {aluno1.Nome}");
            Console.WriteLine($"2. {aluno2.Nome}");
            Console.WriteLine($"3. {aluno3.Nome}");
            Console.WriteLine($"4. {aluno4.Nome}");
            Console.WriteLine($"5. {aluno5.Nome}\n");

            // Exibindo alunos do curso
            Console.WriteLine("ExibirAlunos da classe Curso:");
            Console.WriteLine(curso.ExibirAlunos());

            // Exibindo grade do curso
            Console.WriteLine("\nExibirGrade da classe Curso:");
            Console.WriteLine(curso.ExibirGrade());
        }
    }
}