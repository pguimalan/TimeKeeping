using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class FingerPrintRepository : DataManager, IFingerPrintRepository
    {
        public List<FingerPrintModel> FingerPrint_ByEmpId(int employeeId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<FingerPrintModel>("dbo.Usp_FingerPrint_ByEmpId",
                                  new { @iIntEmployeeId = employeeId },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void FingerPrint_Delete(FingerPrintModel fm)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_FingerPrint_Delete",
                                  new
                                  {
                                      @iIntEmployeeId = fm.EmployeeId,
                                      @iTIntFinger = fm.Finger,
                                      @iIntMask = fm.Mask
                                  },
                                  commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void FingerPrint_Insert(FingerPrintModel fm)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_FingerPrint_Insert",
                                  new {
                                      @iIntEmployeeId = fm.EmployeeId,
                                      @iTIntFinger = fm.Finger,
                                     @iIntMask = fm.Mask
                                  },
                                  commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FingerPrintModel> FingerPrint_SelectAll()
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<FingerPrintModel>("dbo.Usp_FingerPrint_SelectAll",
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
