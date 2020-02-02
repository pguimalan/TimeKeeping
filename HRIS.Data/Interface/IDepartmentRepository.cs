using HRIS.Models;
using System.Collections.Generic;

namespace HRIS.Data.Interface
{
    public interface IDepartmentRepository
    {
        void Department_Insert(DepartmentForInsertModel ad);
        void Department_Update(DepartmentForEditModel ad);
        List<DepartmentForListModel> Department_Select(string search);
        bool Department_CheckIfExists(string deptName);
    }
}
