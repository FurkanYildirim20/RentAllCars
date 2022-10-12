using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Gsm { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
