using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Admin : BaseEntity
    {
        public string Name { get; set; }
        public int Gsm { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
