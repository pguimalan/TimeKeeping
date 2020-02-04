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
    public class EmployeeService : IEmployeeService
    {
        static readonly IEmployeeRepository _repo = new EmployeeRepository();

        public int Employee_Insert(EmployeeForInsertModel em)
        {
            return _repo.Employee_Insert(em);
        }

        public List<EmployeeForSelectModel> Employee_Select(string strSearch)
        {
            return _repo.Employee_Select(strSearch);
        }

        public EmployeeForInsertModel Employee_SelectById(int empId)
        {
            return _repo.Employee_SelectById(empId);
        }

        public void Employee_Update(EmployeeForInsertModel em)
        {
            _repo.Employee_Update(em);
        }
    }
}
