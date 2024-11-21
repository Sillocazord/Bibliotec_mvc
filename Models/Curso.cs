using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Curso
    {  //Atributos
       //int CursoID
       //string Nome;
       //char Periodo;
        [Key]
        public int CursoID { get; set; }
        public string? Nome { get; set; }
        public char Periodo { get; set; }
        
    }
}