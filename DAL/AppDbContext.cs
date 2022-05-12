using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("ChildrenEntertainmentDB")
        {
            
        }

        public virtual DbSet<CustomerInfo> CustomerInfos { get; set; }
        public virtual DbSet<OrderInfo> OrdersInfos { get; set; }
        public virtual DbSet<LeisureInfo> LeisureInfos { get; set; }
    }
}