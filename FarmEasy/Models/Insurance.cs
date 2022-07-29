using System;
using System.Collections.Generic;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Insurance
    {
        public int InsuranceId { get; set; }
        public string InsuranceNum { get; set; }
        public int? CropId { get; set; }
        public int? FarmerId { get; set; }
        public string InsuranceCompany { get; set; }
        public int? SumInsurred { get; set; }
        public int? SharePremimum { get; set; }
        public string CropName { get; set; }
        public string Area { get; set; }
        public bool? Approve { get; set; }
        public bool? Claim { get; set; }
        public long? AccNum { get; set; }
        public string Ifsc { get; set; }

        public virtual Crop Crop { get; set; }
        public virtual Farmer Farmer { get; set; }
    }
}
