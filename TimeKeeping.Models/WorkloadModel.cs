using System;

namespace TimeKeeping.Models
{
    public class WorkloadOfEmployeeModel
    {
        public int WorkloadId { get; set; }
        public string DayOfWork { get; set; }
        public string TimeInAM { get; set; }
        public string TimeOutAM { get; set; }
        public string TimeInPM { get; set; }
        public string TimeOutPM { get; set; }
        public string TimeInEvening { get; set; }
        public string TimeOutEvening { get; set; }
        public decimal TotalNumberOfHours { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string Semester { get; set; }
        public string Designation { get; set; }
        public string DepartmentName { get; set; }
    }

    public class WorkloadModel
    {
        public int WorkloadId { get; set; }
        public int EmployeeId { get; set; }
        public int SemesterId { get; set; }
        public string DayOfWork { get; set; }
        public TimeSpan? TimeInAM { get; set; }
        public TimeSpan? TimeOutAM { get; set; }
        public TimeSpan? TimeInPM { get; set; }
        public TimeSpan? TimeOutPM { get; set; }
        public TimeSpan? TimeInEvening { get; set; }
        public TimeSpan? TimeOutEvening { get; set; }
    }
}
