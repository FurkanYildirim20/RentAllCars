using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentAllCars.Core.Entities.Abstract;

namespace RentAllCars.Data.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
