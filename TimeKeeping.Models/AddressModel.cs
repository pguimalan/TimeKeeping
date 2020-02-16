using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeping.Models
{
    public class AddressModel
    {
        public int AddressId { get; set; }
        public string Barangay { get; set; }
        public string Municipal_City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
