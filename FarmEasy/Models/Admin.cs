using System;
using System.Collections.Generic;

#nullable disable

namespace FarmEasy.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string ContactNum { get; set; }
        public string Email { get; set; }
    }
}
