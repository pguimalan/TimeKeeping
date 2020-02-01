using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Models
{
    public class DepartmentForInsertModel
    {
        public string DepartmentName { get; set; }
    }

    public class DepartmentForEditModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class DepartmentForListModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
