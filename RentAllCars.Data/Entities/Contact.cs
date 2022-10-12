using RentAllCars.Core.BaseEntity;

namespace RentAllCars.Data.Entities
{
    public class Contact : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
