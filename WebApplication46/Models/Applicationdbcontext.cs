using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication46.Models
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext() : 
            base("Data Source=CHETUIWK988\\SQLSERVER;Initial Catalog=yours;Integrated Security=True;Pooling=False") 
        {

        }

       
        public DbSet<cataegory> categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}