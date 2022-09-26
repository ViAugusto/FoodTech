using FoodTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTech.Data
{
    public class ClientPjContext : DbContext
    {
        public ClientPjContext(DbContextOptions<ClientPjContext> opts) : base(opts)
        {

        }
        public DbSet<ClientPjModel> ClientPjModel { get; set; }
        
        
    }
}
