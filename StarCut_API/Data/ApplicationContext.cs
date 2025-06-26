using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace StarCut_API.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptionsBuilder optionsBuilder)
        {
                  
        }
    }
}
