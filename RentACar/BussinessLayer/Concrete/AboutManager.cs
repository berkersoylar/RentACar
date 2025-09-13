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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About Add(About t)
        {
            return _aboutDal.Insert(t);
        }

        public About Delete(About t)
        {
            return _aboutDal.Remove(t);
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> GetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public About Update(About t)
        {
            return _aboutDal.Update(t);
        }
    }
}
