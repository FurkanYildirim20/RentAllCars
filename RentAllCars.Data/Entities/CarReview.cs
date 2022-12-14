using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class CarReview : BaseEntity
    {
        public string Review { get; set; }
        public float Score { get; set; }
        public DateTime Date { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
