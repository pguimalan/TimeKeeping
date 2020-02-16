using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class SemesterService : ISemesterService
    {
        static readonly ISemesterRepository _repo = new SemesterRepository();
        public int Semester_Insert(SemesterModel sem)
        {
            return _repo.Semester_Insert(sem);
        }

        public SemesterModel Semester_SelectById(int id)
        {
            return _repo.Semester_SelectById(id);
        }

        public List<SemesterForDropdownModel> Semester_SelectForDropdown()
        {
            return _repo.Semester_SelectForDropdown();
        }

        public void Semester_Update(SemesterModel sem)
        {
            _repo.Semester_Update(sem);
        }

        public List<SemesterModel> Usp_Semester_Select(string strSearch)
        {
            return _repo.Usp_Semester_Select(strSearch);
        }
    }
}
