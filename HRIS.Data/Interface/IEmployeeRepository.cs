using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Interface
{
    public interface IEmployeeRepository
    {
        int Employee_Insert(EmplyeeForInsertModel em);
        List<EmployeeForSelectModel> Employee_Select(string strSearch);
    }
}
