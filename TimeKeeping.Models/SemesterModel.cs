using System;

namespace TimeKeeping.Models
{
    public class SemesterModel
    {
        public int SemesterId { get; set; }
        public string SemesterDesc { get; set; }
        public string SchoolYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class SemesterForDropdownModel 
    {
        public int SemesterId { get; set; }
        public string SemesterSY { get; set; }
    }
}
