using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

        public List<Car>? Cars { get; set; }
    }
}
