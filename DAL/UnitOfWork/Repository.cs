using System.Data.Entity;

namespace DAL
{
    public abstract class Repository<TDbContext> where TDbContext : DbContext
    {
        protected readonly TDbContext _dbContext;

        public Repository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
