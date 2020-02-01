using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Models
{
    public class AddressForInsertModel
    {
        public string Barangay { get; set; }
        public string Municipal_City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }

    public class AddressForEditModel
    {
        public int AddressId { get; set; }
        public string Barangay { get; set; }
        public string Municipal_City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }

    public class AddressForSelectModel
    {
        public int AddressId { get; set; }
        public string Barangay { get; set; }
        public string Municipal_City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
