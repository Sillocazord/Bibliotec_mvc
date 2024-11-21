using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Categoria
    {  //Atributos
       //int CategoriaID
       //string Nome;
       [Key]
        public int CategoriaID;
        public string? Nome;

    }
}