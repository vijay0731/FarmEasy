using System;
using System.Collections.Generic;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            Crops = new HashSet<Crop>();
            Insurances = new HashSet<Insurance>();
        }

        public int FarmerId { get; set; }
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
        public string FarmLicenceNum { get; set; }
        public string Pswd { get; set; }
        public bool? Approved { get; set; }

        public virtual ICollection<Crop> Crops { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}
