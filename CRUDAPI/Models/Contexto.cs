using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        // Adicionado OfirDev
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa
                {
                    PessoaId = 1,
                    Nome = "Robson",
                    Sobrenome = "O Programador",
                    Idade = 50,
                    Profissao = "Programador"
                },
                new Pessoa
                {
                    PessoaId = 2,
                    Nome = "Rosângela",
                    Sobrenome = "A Secretária da Academia",
                    Idade = 48,
                    Profissao = "Secretária"
                },
                new Pessoa
                {
                    PessoaId = 3,
                    Nome = "Roberta",
                    Sobrenome = "Pode Chamar de Beta",
                    Idade = 26,
                    Profissao = "Vendedora"
                },
                new Pessoa
                {
                    PessoaId = 4,
                    Nome = "Nick",
                    Sobrenome = "The Dog",
                    Idade = 9,
                    Profissao = "Cachorro"
                },
                new Pessoa
                {
                    PessoaId = 5,
                    Nome = "Severino",
                    Sobrenome = "O Faz Tudo",
                    Idade = 40,
                    Profissao = "Faz Tudo"
                }
        );
        }
    }
}