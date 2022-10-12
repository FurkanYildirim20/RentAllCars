using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Rental : BaseEntity
    {
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Status { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
