using RentAllCars.Data.Entities;
using RentAllCars.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAllCars.DataAccess.Concrete
{
    public class EfContactDal : GenericRepository<Contact, RcDbContext>
    {
        public EfContactDal(RcDbContext context) : base(context)
        {
        }
    }
}
