using System.Collections.Generic;
using TimeKeeping.Models;

namespace TimeKeeping.Data.Interface
{
    public interface IWorkloadRepository
    {
        List<WorkloadOfEmployeeModel> Workload_ByEmpSemId(int empId, int semId);
        List<WorkloadOfEmployeeModel> Workload_BySemId(int semId);        
        int Workload_Insert(WorkloadModel wm);
        void Workload_Update(WorkloadModel wm);
        WorkloadModel Workload_SelectById(int id);
    }
}
