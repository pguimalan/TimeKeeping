using HRIS.Data;
using HRIS.Data.Interface;
using HRIS.Models;
using HRIS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Services
{
    public class DepartmentService : IDepartmentService
    {
        static readonly IDepartmentRepository _repo = new DepartmentRepository();

        public void Department_Insert(DepartmentForInsertModel ad)
        {
            _repo.Department_Insert(ad);
        }

        public void Department_Update(DepartmentForEditModel ad)
        {
            _repo.Department_Update(ad);
        }

        public List<DepartmentForListModel> Department_Select(string search)
        {
            return _repo.Department_Select(search);
        }

        public bool Department_CheckIfExists(string deptName)
        {
            return _repo.Department_CheckIfExists(deptName);
        }
    }
}
