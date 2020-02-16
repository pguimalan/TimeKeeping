using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class AddressService : IAddressService
    {
        static readonly IAddressRepository _repo = new AddressRepository();

        public int Address_Insert(AddressModel ad)
        {
            return _repo.Address_Insert(ad);
        }

        public List<AddressModel> Address_Select(string strSearch)
        {
            return _repo.Address_Select(strSearch);
        }

        public int Address_Update(AddressModel ad)
        {
            return _repo.Address_Update(ad);
        }
    }
}
