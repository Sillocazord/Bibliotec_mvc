using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{ //Classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        //CRIAR UM METODO CONSTRUTOR
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        //UnderWrite / Onconfiguring -> Possui a configuração da conexão com o banco de dados

        // colocar as informacoes no banco
        // as configuracoes existem?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            //Aluno:
            //optionsBuilder.IseSqlServer(@"
            //Data source = NOTE01 - SALA28\\SQLEXPRESS;
            //Initial Catalog = Bibliotec_mvc;
            //User Id= sa;
            //Password = 123;
            //Integrated Security=true;
            //TrustServerCertificate = true);
            //SIllas
            if (optionsBuilder.IsConfigured)
            { //a string de conexão de banco de dados
              //Data source => Nome do servidor do banco de dados
              //Initial Catalog => Nome do banco de dados
              //User Id e Password => Informacoes de acesso ao servidor do banco de dados
                optionsBuilder.UseSqlServer("Data Source=NOTE01-SALA28\\SQLEXPRESS; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");
            }

        }

        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Curso> Curso {get; set;}
        public DbSet<Livro> Livro {get; set;}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<LivroCategoria> LivroCategoria {get; set;}
        public DbSet<LivroReserva> LivroReserva {get; set;}
        //Curso
        //Livro
        //Usuario
        //LivroCategoria
        //LivroReserva
    }
}