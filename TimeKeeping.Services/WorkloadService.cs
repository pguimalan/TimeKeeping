using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class WorkloadService : IWorkloadService
    {
        static readonly IWorkloadRepository _repo = new WorkloadRepository();

        public List<WorkloadOfEmployeeModel> Workload_ByEmpSemId(int empId, int semId)
        {
            return _repo.Workload_ByEmpSemId(empId, semId);
        }

        public List<WorkloadOfEmployeeModel> Workload_BySemId(int semId)
        {
            return _repo.Workload_BySemId(semId);
        }

        public int Workload_Insert(WorkloadModel wm)
        {
            return _repo.Workload_Insert(wm);
        }

        public WorkloadModel Workload_SelectById(int id)
        {
            return _repo.Workload_SelectById(id);
        }

        public void Workload_Update(WorkloadModel wm)
        {
            _repo.Workload_Update(wm);
        }
    }
}
