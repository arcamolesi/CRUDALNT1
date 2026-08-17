using Microsoft.EntityFrameworkCore;
using CRUDALNT1.Models;

namespace CRUDALNT1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }



    }
}