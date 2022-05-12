using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class LeisureRepository : Repository<AppDbContext>, IRepository<LeisureInfo>
    {
        public LeisureRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
        }

        public void Add(LeisureInfo entity)
        {
            _dbContext.LeisureInfos.Add(entity);
        }

        public IEnumerable<LeisureInfo> GetAll()
        {
            return _dbContext.LeisureInfos;
        }

        public LeisureInfo GetById(int id)
        {
            return _dbContext.LeisureInfos.Find(id);
        }

        public void Update(LeisureInfo entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
