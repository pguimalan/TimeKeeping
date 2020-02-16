using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeping.Models
{
    public class DTRLogModel
    {
        public int LogId { get; set; }
        public DateTime CurrentDate { get; set; }
        public string Day_Name { get; set; }
        public string Department { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }        
        public string Morning_TimeIn { get; set; }
        public decimal Morning_LateInMins { get; set; }
        public string Morning_TimeOut { get; set; }
        public string Afternoon_TimeIn { get; set; }
        public decimal Afternoon_LateInMins { get; set; }
        public string Afternoon_TimeOut { get; set; }
        public string Evening_TimeIn { get; set; }
        public decimal Evening_LateInMins { get; set; }
        public string Evening_TimeOut { get; set; }
    }
}
