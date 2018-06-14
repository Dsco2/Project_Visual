using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev2.Data
{
    


    public class Dev2Context : DbContext 
    {
        public Dev2Context(DbContextOptions<Dev2Context> options) : base(options)
        {
            // aca no va tambien la cadena de conexjon a db? según el video no la usaron


        }


        public DbSet <Product>Products { get; set; }
        public DbSet <Order> Orders { get; set; }
    }
}
