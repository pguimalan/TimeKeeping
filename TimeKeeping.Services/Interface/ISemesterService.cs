using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface ISemesterService
    {
        void Semester_Update(SemesterModel sem);
        SemesterModel Semester_SelectById(int id);
        List<SemesterModel> Usp_Semester_Select(string strSearch);
        int Semester_Insert(SemesterModel sem);
        List<SemesterForDropdownModel> Semester_SelectForDropdown();
    }
}
