using Graficos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graficos
{
    class Contexto : DbContext
    {
        
        public DbSet<Dados> DADOS { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=127.0.0.1;database=Gilberto;user=root;password=100Senha;sslmode=none");
        }
    }
}
