using APICore.Model;
using Microsoft.EntityFrameworkCore;

namespace APICore
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
