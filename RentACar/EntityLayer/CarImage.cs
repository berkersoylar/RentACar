using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CarImage
    {
        public int CarImageId { get; set; }
        public string ImageUrl { get; set; }

        // Car Bağlantısı
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
