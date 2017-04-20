using System;
using System.Data.Entity;

namespace Agenda.Models
{
    public class atributos
    {
        public int ID { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        
    }

    public class atributosDBContext : DbContext
    {
        public DbSet<atributos> Agenda { get; set; }
    }

}