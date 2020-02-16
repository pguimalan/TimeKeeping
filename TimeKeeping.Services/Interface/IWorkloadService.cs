using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Models;

namespace TimeKeeping.Services.Interface
{
    public interface IWorkloadService
    {
        List<WorkloadOfEmployeeModel> Workload_ByEmpSemId(int empId, int semId);
        List<WorkloadOfEmployeeModel> Workload_BySemId(int semId);
        int Workload_Insert(WorkloadModel wm);
        void Workload_Update(WorkloadModel wm);
        WorkloadModel Workload_SelectById(int id);
    }
}
