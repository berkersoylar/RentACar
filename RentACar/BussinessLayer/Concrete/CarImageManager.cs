using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public EntityLayer.CarImage Add(EntityLayer.CarImage t)
        {
            return _imageDal.Insert(t);
        }

        public EntityLayer.CarImage Delete(EntityLayer.CarImage t)
        {
            return _imageDal.Remove(t);
        }

        public EntityLayer.CarImage GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public List<EntityLayer.CarImage> GetListAll()
        {
            return _imageDal.GetListAll();
        }

        public EntityLayer.CarImage Update(EntityLayer.CarImage t)
        {
            return _imageDal.Update(t);
        }
    }
}
