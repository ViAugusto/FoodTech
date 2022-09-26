using FoodTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTech.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> opts) : base(opts)
        {

        }
        public DbSet<UsuarioModel> UsuarioModel { get; set; }
        
        
    }
}
