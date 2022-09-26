using FoodTech.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTech.Data
{
    public class DonationContext : DbContext
    {
        public DonationContext(DbContextOptions<DonationContext> opts) : base(opts)
        {

        }
        public DbSet<DonationModel> DonationModel { get; set; }
        public DbSet<DeliverDonationModel> DeliverDonationModel { get; set; }

    }
}
