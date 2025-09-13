using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.GenericRepository;
using DataAccessLayer.Context;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        private readonly RentACarContext _context;

        public EfCarDal(RentACarContext context) : base(context)
        {
        }

        public List<Car> GetCampaignCars()
        {
            return _context.Cars.Where(c => c.IsCampaignAvailable && c.CampaignPrice.HasValue).ToList();
        }

        public List<Car> GetCarsWithBrand()
        {
            return _context.Cars.Include(c => c.Brand).ToList();
        }
    }
}
