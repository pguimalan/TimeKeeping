using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Interface
{
    public interface IDepartmentRepository
    {
        void Department_Insert(DepartmentForInsertModel ad);
        void Department_Update(DepartmentForEditModel ad);
        List<DepartmentForListModel> Department_Select(string search);
    }
}
