using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal CarPrice { get; set; }
        public decimal? CampaignPrice { get; set; }
        public bool IsCampaignAvailable { get; set; }

        // Brand Bağlantısı
        public int BrandId { get; set; }
        
        public Brand Brand { get; set; }

        // Image Bağlantısı
        public ICollection<CarImage> Images { get; set; }

    }
}
