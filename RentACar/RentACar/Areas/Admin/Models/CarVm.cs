namespace RentACar.Areas.Admin.Models
{
    public class CarVm
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal CarPrice { get; set; }
        public decimal? CampaignPrice { get; set; }
        public bool IsCampaignAvailable { get; set; }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public List<string> ImageUrls { get; set; } = new List<string>();
        public decimal DisplayPrice => IsCampaignAvailable && CampaignPrice.HasValue ? CampaignPrice.Value : CarPrice;
    }
}
