using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        // Car Bağlantısı
        public ICollection<Car> Cars { get; set; } = new List<Car>();


    }
}
