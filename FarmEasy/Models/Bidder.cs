using System;
using System.Collections.Generic;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Bidder
    {
        public Bidder()
        {
            Crops = new HashSet<Crop>();
        }

        public int BidderId { get; set; }
        public string Name { get; set; }
        public string ContactNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Pincode { get; set; }
        public long? AccNum { get; set; }
        public string Ifsc { get; set; }
        public long? Aadhaar { get; set; }
        public string Pan { get; set; }
        public string TraderLicenceNum { get; set; }
        public string Pswd { get; set; }
        public bool? Approved { get; set; }

        public virtual ICollection<Crop> Crops { get; set; }
    }
}
