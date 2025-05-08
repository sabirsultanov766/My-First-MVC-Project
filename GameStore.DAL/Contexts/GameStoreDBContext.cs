using GameStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Contexts
{
    public class GameStoreDBContext : DbContext
    {
        private readonly string _context = "Server = localhost;Database = GameStoreDB;Trusted_Connection = true;TrustServerCertificate = true";
        
        public DbSet<GameProduct> gameProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_context);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
