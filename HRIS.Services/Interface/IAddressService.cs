using HRIS.Models;
using System.Collections.Generic;

namespace HRIS.Services.Interface
{
    public interface IAddressService
    {
        int AddressInsert(AddressForInsertModel ad);
        List<AddressForSelectModel> AddressSelect(string strSearch);
        int AddressUpdate(AddressForEditModel ad);
    }
}
