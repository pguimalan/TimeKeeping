using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class PayrollService : IPayrollService
    {
        static readonly IPayrollRepository _repo = new PayrollRepository();

        public PayrollModel GetPayrollDetails(int employeeId, int payrollPeriodId)
        {
            return _repo.GetPayrollDetails(employeeId, payrollPeriodId);
        }

        public List<PayrollModel> GetPayrollList(int payrollPeriodId, string empType)
        {
            return _repo.GetPayrollList(payrollPeriodId, empType);
        }

        public void Payroll_Process(PayrollModel payrollModel)
        {
            _repo.Payroll_Process(payrollModel);
        }
    }
}
