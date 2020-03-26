using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeping.Models
{
    public class PayrollModel
    {
        public int PayrollId { get; set; }
        public int EmployeId { get; set; }
        public string EmployeeFullName { get; set; }
        public int PayrollPeriodId { get; set; }
        public string InclusiveDates { get; set; }
        public decimal HDMF_Premiums { get; set; }
        public decimal HDMF_MPL { get; set; }
        public decimal HDMF_Calamity { get; set; }
        public decimal Cottage_Rental { get; set; }
        public decimal Tax { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal SSS { get; set; }
        public decimal MinsLate { get; set; }
        public decimal UnderTime { get; set; }
        public decimal OverTime { get; set; }
        public decimal PayRate { get; set; }
        public string PayOption { get; set; }
        public decimal TotalDaysWork { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string EmpType { get; set; }
        public string GeneratedBy { get; set; }
        public DateTime GeneratedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public decimal LateAmtDeduction { get; set; }
        public decimal UnderTimeAmtDeduction { get; set; }
    }
}
