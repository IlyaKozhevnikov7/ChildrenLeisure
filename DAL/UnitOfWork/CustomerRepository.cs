using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class CustomerRepository : Repository<AppDbContext>, IRepository<CustomerInfo>
    {
        public CustomerRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEnumerable<CustomerInfo> GetAll()
        {
            return _dbContext.CustomerInfos;
        }

        public void Add(CustomerInfo entity)
        {
            _dbContext.CustomerInfos.Add(entity);
        }

        public CustomerInfo GetById(int id)
        {
            return _dbContext.CustomerInfos.Find(id);
        }

        public void Update(CustomerInfo entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
