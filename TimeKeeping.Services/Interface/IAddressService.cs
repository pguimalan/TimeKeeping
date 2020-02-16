using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IAddressService
    {
        int Address_Insert(AddressModel ad);
        List<AddressModel> Address_Select(string strSearch);
        int Address_Update(AddressModel ad);
    }
}
