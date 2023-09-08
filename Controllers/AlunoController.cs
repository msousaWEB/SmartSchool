using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly List<Aluno> _alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Matheus",
                Sobrenome = "Sousa",
                Telefone = "19996895894"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Kayene",
                Sobrenome = "Rocha",
                Telefone = "19996895896"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Maria",
                Sobrenome = "Vaz",
                Telefone = "19696895894"
            },
        };

        public AlunoController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_alunos);
        }

        [HttpGet("id/{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }

        [HttpGet("nome")]
        public IActionResult GetByNome(string nome)
        {
            var aluno = _alunos.FirstOrDefault(a =>
                a.Nome.Contains(nome) && a.Sobrenome.Contains(nome)
            );
            if (aluno == null) return BadRequest("Aluno não encontrado!");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id:int}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }
        
        [HttpPatch("{id:int}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok("Aluno removido!");
        }
    }
}