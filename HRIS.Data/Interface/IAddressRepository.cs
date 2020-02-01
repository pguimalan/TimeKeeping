using HRIS.Models;
using System.Collections.Generic;

namespace HRIS.Data.Interface
{
    public interface IAddressRepository
    {
        int AddressInsert(AddressForInsertModel ad);
        List<AddressForSelectModel> AddressSelect(string strSearch);
        int AddressUpdate(AddressForEditModel ad);
    }
}