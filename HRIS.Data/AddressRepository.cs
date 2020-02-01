using Dapper;
using HRIS.Data.Interface;
using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HRIS.Data
{
    public class AddressRepository : DataManager, IAddressRepository
    {
        public int AddressInsert(AddressForInsertModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                  var result = con.ExecuteScalar<int>("dbo.Usp_AddressInsert",
                              new
                              {
                                  @iStrBarangay = ad.Barangay,
                                  @iStrMunicipal_City =ad.Municipal_City,
                                  @iStrProvince = ad.Province,
                                  @iStrCountry = ad.Country,
                                  @iStrZipCode = ad.ZipCode
                              }, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AddressForSelectModel> AddressSelect(string strSearch)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<AddressForSelectModel>("dbo.Usp_AddressSelect",
                                  new { @iStrSearch = strSearch },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddressUpdate(AddressForEditModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.ExecuteScalar<int>("dbo.Usp_AddressUpdate",
                                new
                                {
                                    @iIntAddressId = ad.AddressId,
                                    @iStrBarangay = ad.Barangay,
                                    @iStrMunicipal_City = ad.Municipal_City,
                                    @iStrProvince = ad.Province,
                                    @iStrCountry = ad.Country,
                                    @iStrZipCode = ad.ZipCode
                                }, commandType: CommandType.StoredProcedure);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
