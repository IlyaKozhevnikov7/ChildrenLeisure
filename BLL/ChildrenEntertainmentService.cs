                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      using DAL;
using DAL.Models;

namespace BLL
{
    public class ChildrenEntertainmentService
    {
        public Customer? Client { get; private set; }
        
        private readonly UnitOfWork _unitOfWork = new();
        private readonly Dictionary<DAL.LeisureType, int> _leisurePrices = new Dictionary<DAL.LeisureType, int>();

        private static ChildrenEntertainmentService _instance;

        private ChildrenEntertainmentService()
        {
            var leisures = _unitOfWork.LeisureRepository.GetAll();

            foreach (var leisure in leisures)
                _leisurePrices.Add(leisure.Type, leisure.Price);
        }

        public static ChildrenEntertainmentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChildrenEntertainmentService();
                }

                return _instance;
            }
        }

        public int GetLeisurePrice(LeisureType leisureType)
        {
            return _leisurePrices[(DAL.LeisureType)leisureType];
        }

        public bool TryMakeOrder(LeisureType selectedIndex)
        {
            DAL.LeisureType leisureType = (DAL.LeisureType)selectedIndex;

            try
            {
                Client.WithdrawCash(_leisurePrices[leisureType]);
            }
            catch (InvalidOperationException)
            {
                return false;
            }

            OrderInfo orderInfo = new OrderInfo
            {
                CustomerInfoId = Client.id,
                CustomerInfo = _unitOfWork.CustomerRepository.GetById(Client.id),
                LeisureType = (DAL.LeisureType)selectedIndex
            };

            _unitOfWork.OrderRepository.Add(orderInfo);
            _unitOfWork.Save();

            return true;
        }

        public async Task<bool> TryLoginAsync(string name, string password)
        {
            CustomerInfo[] customerInfos = await Task.Run(() => _unitOfWork.CustomerRepository.GetAll()
                .Where(customer => customer.Name == name && customer.Password == password)
                .ToArray());

            Client = customerInfos != null && customerInfos.Length > 0
                ? new Customer(customerInfos[0])
                : null;

            if (Client != null)
            {
                Client.Changed += OnClientChangedAsync;
                return true;
            }

            return false;
        }

        public async Task<bool> TrySignInAsync(string name, string password)
        {
            bool alreadyExist = await Task.Run(() => _unitOfWork.CustomerRepository.GetAll()
                .Where(customer => customer.Name == name && customer.Password == password)
                .Any());

            if (alreadyExist)
                return false;

            var newCustomerInfo = new CustomerInfo
            {
                Name = name,
                Password = password,
                Cash = 0
            };

            _unitOfWork.CustomerRepository.Add(newCustomerInfo);
            await Task.Run(() => _unitOfWork.Save());
            return true;
        }

        public async Task<Order[]> ReceiveOrders()
        {
            var orders = Task.Run(() => _unitOfWork.OrderRepository.GetAll()
                .Where(order => order.CustomerInfoId == Client.id)
                .ToArray()).Result;

            var resultOrders = new Order[orders.Length];

            for (int i = 0; i < resultOrders.Length; i++)
            {
                resultOrders[i] = new Order
                {
                    Id = i,
                    LeisureType = (LeisureType)orders[i].LeisureType
                };
            }

            return resultOrders;
        }

        private async void OnClientChangedAsync()
        {
            var customerInfo = await Task.Run(() => _unitOfWork.CustomerRepository.GetAll()
                .Where(customer => customer.Id == Client.id)
                .First());

            customerInfo.Name = Client.name;
            customerInfo.Password = Client.password;
            customerInfo.Cash = Client.Cash;

            _unitOfWork.CustomerRepository.Update(customerInfo);
            await Task.Run(() => _unitOfWork.Save());
        }
    }
}                                                                                                                                                                                                                                                                                                      