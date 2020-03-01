using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class EmployeeLeaveRepository : DataManager, IEmployeeLeaveRepository
    {
        public int EmployeeLeave_Insert(EmployeeLeaveForInsertodel lv)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_EmployeeLeave_Insert",
                                new
                                {
                                    @iIntEmployeeId = lv.EmployeeId,
                                    @iStrLeaveType = lv.LeaveType,
                                    @iBitIsWithPay = lv.IsWithPay,
                                    @iStrLeaveRemarks = lv.LeaveRemarks,
                                    @iDtLeaveDateFrom = lv.LeaveDateFrom,
                                    @iDtLeaveDateTo = lv.LeaveDateTo,
                                    @iStrCreatedBy = lv.CreatedBy
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmployeeLeaveForListodel> EmployeeLeave_Select(int employeeId, DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<EmployeeLeaveForListodel>("dbo.Usp_EmployeeLeave_Select",
                                  new { @iIntEmployee = employeeId, @iDtDateFrom = dtFrom, @iDtDateTO = dtTo },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EmployeeLeave_Update(EmployeeLeaveForInsertodel lv)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_EmployeeLeave_Update",
                                new
                                {
                                    @iIntEmployeeId = lv.EmployeeId,
                                    @iStrLeaveType = lv.LeaveType,
                                    @iBitIsWithPay = lv.IsWithPay,
                                    @iStrLeaveRemarks = lv.LeaveRemarks,
                                    @iDtLeaveDateFrom = lv.LeaveDateFrom,
                                    @iDtLeaveDateTo = lv.LeaveDateTo,
                                    @iStrCreatedBy = lv.CreatedBy
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
