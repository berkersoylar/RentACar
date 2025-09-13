using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand Add(Brand t)
        {
            return _brandDal.Insert(t);
        }

        public Brand Delete(Brand t)
        {
            return _brandDal.Remove(t);
        }

        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
        }

        public List<Brand> GetListAll()
        {
            return _brandDal.GetListAll();
        }

        public Brand Update(Brand t)
        {
            return _brandDal.Update(t);
        }
    }
}
