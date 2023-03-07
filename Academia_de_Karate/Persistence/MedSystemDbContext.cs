using System;
using Academia_de_Karate.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academia_de_Karate.Persistence
{
    public class MedSystemDbContext : DbContext
    {
        public MedSystemDbContext(DbContextOptions<MedSystemDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}