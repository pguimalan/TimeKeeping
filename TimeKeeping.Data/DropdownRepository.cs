using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class DropdownRepository : DataManager, IDropdownRepository
    {
        public List<EmployeeForDropdown> Employee_SelectDropdown()
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<EmployeeForDropdown>("dbo.Usp_Employee_SelectDropdown",
                                  null,
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PayrollPeriodDropdown> PayrollPeriod_SelectDropdown()
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<PayrollPeriodDropdown>("dbo.Usp_PayrollPeriod_SelectDropdown",
                                  null,
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
