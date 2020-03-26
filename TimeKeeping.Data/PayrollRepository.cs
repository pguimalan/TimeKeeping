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
    public class PayrollRepository : DataManager, IPayrollRepository
    {
        public PayrollModel GetPayrollDetails(int employeeId, int payrollPeriodId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<PayrollModel>("dbo.Usp_Payroll_ById",
                                 new { @iIntEmployeeId = employeeId, @iIntPayrollPeriodId = payrollPeriodId },
                                 commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PayrollModel> GetPayrollList(int payrollPeriodId, string empType)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<PayrollModel>("dbo.Usp_Payroll_List",
                                 new { @iIntPayrollPeriodId = payrollPeriodId, @iStrEmpType = empType },
                                 commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Payroll_Process(PayrollModel payrollModel)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Payroll_Process",
                                new
                                {
                                    @iIntEmployeId = payrollModel.EmployeId,
                                    @iIntPayrollPeriodId = payrollModel.PayrollPeriodId,
                                    @iDecHDMF_Premiums = payrollModel.HDMF_Premiums,
                                    @iDecHDMF_MPL = payrollModel.HDMF_MPL,
                                    @iDecHDMF_Calamity = payrollModel.HDMF_Calamity,
                                    @iDecCottage_Rental = payrollModel.Cottage_Rental,
                                    @iDecTax = payrollModel.Tax,
                                    @iDecPhilHealth = payrollModel.PhilHealth,
                                    @iDecSSS = payrollModel.SSS,
                                    @iDecMinsLate = payrollModel.MinsLate,
                                    @iDecUnderTime = payrollModel.UnderTime,
                                    @iDecOverTime = payrollModel.OverTime,
                                    @iDecPayRate = payrollModel.PayRate,
                                    @iStrPayOption = payrollModel.PayOption,
                                    @iDecTotalDaysWork = payrollModel.TotalDaysWork,
                                    @iDecGrossAmount = payrollModel.GrossAmount,
                                    @iDecNetAmount = payrollModel.NetAmount,
                                    @iStrEmpType = payrollModel.EmpType,
                                    @iStrGeneratedBy = payrollModel.GeneratedBy,
                                    @iDecLateAmtDeduction = payrollModel.LateAmtDeduction,
                                    @iDecUnderTimeAmtDeduction = payrollModel.UnderTimeAmtDeduction
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
