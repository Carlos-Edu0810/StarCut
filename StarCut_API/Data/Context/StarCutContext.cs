using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StarCut_Library.Models;

namespace StarCut_API.Data.Context
{
    public class StarCutContext : DbContext
    {
        public StarCutContext(DbContextOptions<StarCutContext> options) : base(options)
        {
                  
        }

        public void onModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StarCutContext).Assembly);
        }
    }
}
