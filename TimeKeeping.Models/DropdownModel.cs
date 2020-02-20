using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeping.Models
{
    public class EmployeeForDropdown
    {
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
    }

    public class PayrollPeriodDropdown
    {
        public int PeriodId { get; set; }
        public string PPMonthYear { get; set; }
    }
}
