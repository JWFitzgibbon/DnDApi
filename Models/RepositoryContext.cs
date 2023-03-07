using Microsoft.EntityFrameworkCore;

namespace DnDApi.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Ability> Abilities { get; set; }
    }
}