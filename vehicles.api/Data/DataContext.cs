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

        public DbSet<VehicleType> vehicleTypes { get; set; }

        
        //override muestra los metodos que se pueden sobre escribir
        //OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //indice unico adescripcion
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
