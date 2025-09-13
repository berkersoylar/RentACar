using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> GetCampaingCars();
        List<Car> GetCarsWithBrand();
    }
}
