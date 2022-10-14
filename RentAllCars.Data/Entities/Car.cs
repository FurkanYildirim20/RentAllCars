using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Car : BaseEntity
    {
        public int CarId { get; set; }  
        public string Title { get; set; }
        public int ManufacturedYear { get; set; }
        public string Description { get; set; }
        public string? ThumbnailImage { get; set; }
        public string Image { get; set; }
        public int Capacity { get; set; }
        public DateTime CreateDate { get; set; }
        public float Rate { get; set; }
        public bool Status { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
