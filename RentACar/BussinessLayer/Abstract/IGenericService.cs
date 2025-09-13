using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        T Add(T t);
        T Update (T t);
        T Delete(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
