using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface ISemesterRepository
    {
        void Semester_Update(SemesterModel sem);
        SemesterModel Semester_SelectById(int id);
        List<SemesterModel> Usp_Semester_Select(string strSearch);
        int Semester_Insert(SemesterModel sem);

        List<SemesterForDropdownModel> Semester_SelectForDropdown();
    }
}
