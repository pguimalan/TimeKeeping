using System;

namespace TimeKeeping.Models
{
    public class FingerPrintModel
    {
        public int FPId { get; set; }
        public int EmployeeId { get; set; }
        public Int16 Finger { get; set; }
        public int Mask { get; set; }
    }
}
