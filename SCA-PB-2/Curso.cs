using System.Text;

namespace SCA_PB_2
{
    public class Curso
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; } // Relacionamento de classe com Aluno (Curso possui Aluno) 1:N
        public Grade Grade { get; set; } // Relacionamento de classe com Grade (Curso possui Grade) 1:1

        public Curso(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Alunos = new List<Aluno>();
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public string ExibirAlunos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alunos do curso {Nome}:");
            foreach (var aluno in Alunos)
            {
                sb.AppendLine($"Matrícula: {aluno.Matricula}, Nome: {aluno.Nome}");
            }
            return sb.ToString();
        }

        public string ExibirGrade()
        {
            if (Grade == null)
            {
                return "Curso não possui grade definida.";
            }
            else
            {
                return Grade.ExibirGrade();
            }
        }
    }
}