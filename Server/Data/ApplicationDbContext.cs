using BuBTT.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BuBTT.Server
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}