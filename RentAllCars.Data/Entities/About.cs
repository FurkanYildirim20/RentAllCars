using RentAllCars.Core.Entities.Concrete;

namespace RentAllCars.Data.Entities
{
    public class About : BaseEntity
    {
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string About1 { get; set; }
        public string About2 { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
