using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IDepartmentService
    {
        int Department_Insert(DepartmentModel ad);
        void Department_Update(DepartmentModel ad);
        List<DepartmentModel> Department_Select(string search);
        List<DepartmentModel> Department_SelectForDTR();
    }
}
