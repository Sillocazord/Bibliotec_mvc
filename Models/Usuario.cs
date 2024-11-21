using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {  //Atributos
       //int UsuarioID
       //string Nome;
       //DateOnly DtNascimento;
       //string Email;
       //string Senha;
       //string Contato;
       //bool Admin;
       //bool Status;
       [Key]
        public int UsuarioID {get;set;}
        public string? Nome {get;set;}
        public DateOnly DtNascimento {get;set;}
        public string? Email {get;set;}
        public string? Senha {get;set;}
        public string? Contato {get;set;}
        public bool Admin {get;set;}
        public bool Status {get;set;}

        //Criar Atributo
        //Eu falo para este atributo que ele é uma FK
        [ForeignKey("Curso")]
        public int CursoID {get;set;}

        public Curso Curso {get;set;}

    }
}