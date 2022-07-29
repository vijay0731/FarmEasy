using System;
using System.Collections.Generic;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Crop
    {
        public Crop()
        {
            Insurances = new HashSet<Insurance>();
        }

        public int CropId { get; set; }
        public int? FarmerId { get; set; }
        public string CropType { get; set; }
        public string CropName { get; set; }
        public string FertilizerType { get; set; }
        public int? Qunatity { get; set; }
        public int? BasePrice { get; set; }
        public int? BidderId { get; set; }
        public int? CurrentBid { get; set; }
        public int? SoldPrice { get; set; }
        public DateTime? SellDate { get; set; }
        public string Status { get; set; }

        public virtual Bidder Bidder { get; set; }
        public virtual Farmer Farmer { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}
