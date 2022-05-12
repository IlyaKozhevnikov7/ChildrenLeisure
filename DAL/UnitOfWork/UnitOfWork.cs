using System;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext _context = new AppDbContext();

        private CustomerRepository _customerRepository;
        private OrderRepository _orderRepository;
        private LeisureRepository _leisureRepository;

        private bool disposed = false;

        public CustomerRepository CustomerRepository
        {
            get 
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_context);

                return _customerRepository;
            }
        }

        public OrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new OrderRepository(_context);

                return _orderRepository;
            }
        }

        public LeisureRepository LeisureRepository
        {
            get
            {
                if (_leisureRepository == null)
                    _leisureRepository = new LeisureRepository(_context);

                return _leisureRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed == false)
            {
                if (disposing)
                    _context.Dispose();

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
