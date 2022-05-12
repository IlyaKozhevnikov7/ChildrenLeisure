using System.Collections.Generic;
using System.Data.Entity;
using DAL.Models;

namespace DAL
{
    public class OrderRepository : Repository<AppDbContext>, IRepository<OrderInfo>
    {
        public OrderRepository(AppDbContext dbContext) 
            : base(dbContext)
        {
        }

        public IEnumerable<OrderInfo> GetAll()
        {
            return _dbContext.OrdersInfos;
        }

        public void Add(OrderInfo entity)
        {
            _dbContext.OrdersInfos.Add(entity);
        }

        public OrderInfo GetById(int id)
        {
            return _dbContext.OrdersInfos.Find(id);
        }

        public void Update(OrderInfo entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
