﻿namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina()
        {
        }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}