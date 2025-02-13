using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigMacFood.Models;
using Microsoft.EntityFrameworkCore;

namespace BigMacFood.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<Categoria> Categorias{get; set;}

        public DbSet<Lanche> Lanches{get; set;}
        
    }
}