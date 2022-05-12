
namespace DAL.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }
        public int CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public LeisureType LeisureType { get; set; }
    }
}
