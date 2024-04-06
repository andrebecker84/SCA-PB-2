using System.Text;

namespace SCA_PB_2
{
    public class Grade
    {
        public List<Disciplina> Disciplinas { get; set; } // Relacionamento de classe com Disciplina (Grade possui Disciplina) N:N

        public Grade()
        {
            Disciplinas = new List<Disciplina>(); 
        }

        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public string ExibirGrade()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Grade:");
            foreach (var disciplina in Disciplinas)
            {
                sb.AppendLine($"Código: {disciplina.Codigo}, Nome: {disciplina.Nome}");
            }
            return sb.ToString();
        }
    }
}