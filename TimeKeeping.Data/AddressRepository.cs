using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class AddressRepository : DataManager, IAddressRepository
    {
        public int Address_Insert(AddressModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.ExecuteScalar<int>("dbo.Usp_Address_Insert",
                                new
                                {
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

        public List<AddressModel> Address_Select(string strSearch)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<AddressModel>("dbo.Usp_Address_Select",
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

        public int Address_Update(AddressModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.ExecuteScalar<int>("dbo.Usp_Address_Update",
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
