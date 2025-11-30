using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebFamilyAspApi.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Connection string fixa para migrations (Railway ou local)
            optionsBuilder.UseNpgsql("Host=trolley.proxy.rlwy.net;Port=18144;Database=railway;Username=postgres;Password=rdUuVVuXPSjzjuovITHXxHjZXUadslSN");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
