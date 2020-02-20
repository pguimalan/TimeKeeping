using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IDropdownRepository
    {
        List<EmployeeForDropdown> Employee_SelectDropdown();
        List<PayrollPeriodDropdown> PayrollPeriod_SelectDropdown();
    }
}
