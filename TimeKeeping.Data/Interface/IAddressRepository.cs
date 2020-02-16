using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IAddressRepository
    {
        int Address_Insert(AddressModel ad);
        List<AddressModel> Address_Select(string strSearch);
        int Address_Update(AddressModel ad);
    }
}
