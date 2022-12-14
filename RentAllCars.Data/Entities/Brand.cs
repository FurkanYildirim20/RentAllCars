using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Brand : BaseEntity
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; }
    }
}
