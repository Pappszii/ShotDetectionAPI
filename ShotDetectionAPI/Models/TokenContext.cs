using Microsoft.EntityFrameworkCore;


namespace ShotDetectionAPI.Models
{
    public class TokenContext : DbContext
    {
        public TokenContext(DbContextOptions<TokenContext> options)
            : base(options)
        {
            
        }

        public DbSet<Token> Tokens { get; set; }
    }
}
