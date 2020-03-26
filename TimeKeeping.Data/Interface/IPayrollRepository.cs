using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IPayrollRepository
    {
        void Payroll_Process(PayrollModel payrollModel);

        PayrollModel GetPayrollDetails(int employeeId, int payrollPeriodId);
        List<PayrollModel> GetPayrollList(int payrollPeriodId, string empType);
    }
}
