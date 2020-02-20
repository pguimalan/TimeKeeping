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

    public class IndividualDTR
    {
        public int LogId { get; set; }
        public string DayOfWeekName { get; set; }
        public string TimeIn_AM { get; set; }
        public string TimeOut_AM { get; set; }
        public string TimeIn_PM { get; set; }
        public string TimeOut_PM { get; set; }
        public string TimeIn_Evening { get; set; }
        public string TimeOut_Evening { get; set; }
        public string EmployeeFullName { get; set; }
        public string Designation { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime CurrDate { get; set; }
    }

    public class DTRByIdModel
    {
        public int LogId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string CurrentDate { get; set; }
        public string TimeIn_AM { get; set; }
        public string TimeOut_AM { get; set; }
        public string TimeIn_PM { get; set; }
        public string TimeOut_PM { get; set; }
        public string TimeIn_Evening { get; set; }
        public string TimeOut_Evening { get; set; }
    }

    public class DTRForceUpdateModel
    {
        public int LogId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CurrentDate { get; set; }
        public TimeSpan? TimeIn_AM { get; set; }
        public TimeSpan? TimeOut_AM { get; set; }
        public TimeSpan? TimeIn_PM { get; set; }
        public TimeSpan? TimeOut_PM { get; set; }
        public TimeSpan? TimeIn_Evening { get; set; }
        public TimeSpan? TimeOut_Evening { get; set; }
        public int UserId { get; set; }
    }
}


