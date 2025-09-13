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
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(RentACarContext context) : base(context)
        {
        }
    }
}
