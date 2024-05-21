using AbcCompanyRDMS.Models;
using Microsoft.EntityFrameworkCore;

namespace AbcCompanyRDMS.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Reseller> Resellers { get; set; }
    }
}
