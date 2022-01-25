using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class Repositorio : DbContext
    {
        // Configuracion de las entidades
        public DbSet<Address> Addresses{get;set;}
        public DbSet<City> Cities { get; set; }
        public DbSet<Country>Countries { get; set; }
        //configuracion de conexion 
        override protected void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            //conexion con sql server
            opciones.UseSqlServer("Server=DESKTOP-EF56O4A; initial catalog=IGU; trusted_connection=true;");

        }

    }
}
