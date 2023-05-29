using System;
using Academia_de_Karate.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academia_de_Karate.Persistence
{
    public class AcademiaDeKarateDbContext : DbContext
    {
        public AcademiaDeKarateDbContext(DbContextOptions<AcademiaDeKarateDbContext> options) : base(options)
        {
            
        }
        public DbSet<Aluno>? Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasKey(b => b.Id);
        }
    }
}