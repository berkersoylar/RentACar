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
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car Add(Car t)
        {
            return _carDal.Insert(t);
        }

        public Car Delete(Car t)
        {
            return _carDal.Remove(t);
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Car> GetCampaingCars()
        {
            return _carDal.GetCampaignCars();
        }

        public List<Car> GetCarsWithBrand()
        {
            return _carDal.GetCarsWithBrand();
        }

        public List<Car> GetListAll()
        {
            return _carDal.GetListAll();
        }

        public Car Update(Car t)
        {
            return _carDal.Update(t);
        }
    }
}
