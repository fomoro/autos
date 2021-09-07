using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicles.api.Data.Entities;

namespace vehicles.api.Data
{
    public class DataContext : DbContext
    {
        //DbContextOptions es un generico basado en esta clase
        //pasamos los parametros al super contructor de la clase padre
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }


        //override muestra los metodos que se pueden sobre escribir
        //OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //indice unico adescripcion
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<Brand>().HasIndex(x => x.Description).IsUnique();
            modelBuilder.Entity<DocumentType>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
