using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.GenericRepository;
using DataAccessLayer.Context;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(RentACarContext context) : base(context)
        {
        }
    }
}
