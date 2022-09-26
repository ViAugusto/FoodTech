using FoodTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTech.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> opts) : base(opts)
        {

        }
        public DbSet<ClientModel> ClientModel { get; set; }
        
        
    }
}
