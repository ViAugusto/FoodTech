using FoodTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTech.Data
{
    public class EnderecoContext : DbContext
    {
        public EnderecoContext(DbContextOptions<EnderecoContext> opts) : base(opts)
        {

        }
        public DbSet<EnderecoModel> EnderecoModel { get; set; }
        
        
    }
}
