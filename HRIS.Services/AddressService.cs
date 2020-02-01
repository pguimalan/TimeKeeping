using HRIS.Data;
using HRIS.Data.Interface;
using HRIS.Models;
using HRIS.Services.Interface;
using System;
using System.Collections.Generic;

namespace HRIS.Services
{
    public class AddressService : IAddressService
    {
        static readonly IAddressRepository _repo = new AddressRepository();

        public int AddressInsert(AddressForInsertModel ad)
        {
            return _repo.AddressInsert(ad);
        }

        public List<AddressForSelectModel> AddressSelect(string strSearch)
        {
            return _repo.AddressSelect(strSearch);
        }

        public int AddressUpdate(AddressForEditModel ad)
        {
            return _repo.AddressUpdate(ad);
        }
    }
}
