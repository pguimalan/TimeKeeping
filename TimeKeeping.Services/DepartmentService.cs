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
    public class DepartmentService : IDepartmentService
    {
        static readonly IDepartmentRepository _repo = new DepartmentRepository();

        public int Department_Insert(DepartmentModel ad)
        {
            return _repo.Department_Insert(ad);
        }

        public List<DepartmentModel> Department_Select(string search)
        {
            return _repo.Department_Select(search);
        }

        public List<DepartmentModel> Department_SelectForDTR()
        {
            return _repo.Department_SelectForDTR();
        }

        public void Department_Update(DepartmentModel ad)
        {
            _repo.Department_Update(ad);
        }
    }
}
