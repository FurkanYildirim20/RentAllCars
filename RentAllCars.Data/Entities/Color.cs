using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Color : BaseEntity
    {
        public int ColorId { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
