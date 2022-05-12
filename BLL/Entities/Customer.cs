using DAL.Models;

namespace BLL
{
    public class Customer
    {
        public readonly int id;
        public readonly string name;
        public readonly string password;

        private int _cash;

        public event Action<int> CashChanged;
        public event Action Changed;

        public Customer(CustomerInfo info)
        {
            id = info.Id;
            name = info.Name;
            password = info.Password;
            _cash = info.Cash;
        }

        public int Cash => _cash;

        public void TopUpCash(int amount)
        {
            _cash += amount;
            CashChanged?.Invoke(_cash);
            Changed?.Invoke();
        }

        public void WithdrawCash(int amount)
        {
            if (amount > _cash)
                throw new InvalidOperationException();

            _cash -= amount;    
            CashChanged?.Invoke(_cash);
            Changed?.Invoke();
        }
    }
}
