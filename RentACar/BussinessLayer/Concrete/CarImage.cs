using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CarImage : ICarImageService
    {
        private readonly ICarImageDal _imageDal;

        public CarImage(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public EntityLayer.CarImage Add(EntityLayer.CarImage t)
        {
            throw new NotImplementedException();
        }

        public EntityLayer.CarImage Delete(EntityLayer.CarImage t)
        {
            throw new NotImplementedException();
        }

        public EntityLayer.CarImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.CarImage> GetListAll()
        {
            throw new NotImplementedException();
        }

        public EntityLayer.CarImage Update(EntityLayer.CarImage t)
        {
            throw new NotImplementedException();
        }
    }
}
