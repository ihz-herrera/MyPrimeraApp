using Microsoft.EntityFrameworkCore;
using MyPrimeraApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrimeraApp.Contextos
{
    public class Context : DbContext
    {

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\BaseDeDatos\\Escuela.db");
            //optionsBuilder.UseSqlServer("server=.;database = Escuela;Encrypt=false; Trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>().HasKey(x => x.id);
        }
    }
}
