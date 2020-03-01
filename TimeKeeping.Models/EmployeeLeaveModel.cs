using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeping.Models
{
    public class EmployeeLeaveForListodel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string LeaveType { get; set; }
        public DateTime LeaveDateFrom { get; set; }
        public DateTime LeaveDateTo { get; set; }
        public int NoDaysLeave { get; set; }
        public string LeaveStatus { get; set; }
    }

    public class EmployeeLeaveForInsertodel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string LeaveType { get; set; }
        public bool IsWithPay { get; set; }
        public string LeaveRemarks { get; set; }
        public DateTime LeaveDateFrom { get; set; }
        public DateTime LeaveDateTo { get; set; }
        public string CreatedBy { get; set; }
    }
}
