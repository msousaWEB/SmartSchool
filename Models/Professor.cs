using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public Professor(int id, string nome, IEnumerable<Disciplina> disciplinas)
        {
            Id = id;
            Nome = nome;
            Disciplinas = disciplinas;
        }
    }
}