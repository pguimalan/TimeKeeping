using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;

namespace TimeKeeping.Data
{
    public class WorkloadRepository : DataManager, IWorkloadRepository
    {
        public List<WorkloadOfEmployeeModel> Workload_ByEmpSemId(int empId, int semId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<WorkloadOfEmployeeModel>("dbo.Usp_Workload_ByEmpSemId",
                                  new { @iIntEmployeeId = empId, @iIntSemId = semId },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<WorkloadOfEmployeeModel> Workload_BySemId(int semId)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<WorkloadOfEmployeeModel>("dbo.Usp_Workload_BySemId",
                                  new { @iIntSemId = semId },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Workload_Insert(WorkloadModel wm)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var retValue = con.ExecuteScalar<int>("dbo.Usp_Workload_Insert",
                                new
                                {
                                    @iIntEmployeeId = wm.EmployeeId,
                                    @iIntSemesterId = wm.SemesterId,
                                    @iStrDayOfWork = wm.DayOfWork,
                                    @iTmTimeInAM = wm.TimeInAM == TimeSpan.Zero ? null : wm.TimeInAM,
                                    @iTmTimeOutAM = wm.TimeOutAM == TimeSpan.Zero ? null : wm.TimeOutAM,
                                    @iTmTimeInPM = wm.TimeInPM == TimeSpan.Zero ? null: wm.TimeInPM,
                                    @iTmTimeOutPM = wm.TimeOutPM == TimeSpan.Zero ? null : wm.TimeOutPM,
                                    @iTmTimeInEvening = wm.TimeInEvening == TimeSpan.Zero ? null : wm.TimeInEvening,
                                    @iTmTimeOutEvening = wm.TimeOutEvening == TimeSpan.Zero ? null : wm.TimeOutEvening
                                }, commandType: CommandType.StoredProcedure);

                    return retValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public WorkloadModel Workload_SelectById(int id)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.QueryFirstOrDefault<WorkloadModel>("dbo.Usp_Workload_SelectById",
                                  new { @iIntWorkloadId = id },
                                  commandType: CommandType.StoredProcedure);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Workload_Update(WorkloadModel wm)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Workload_Update",
                                new
                                {
                                    @iIntWorkloadId = wm.WorkloadId,
                                    @iIntEmployeeId = wm.EmployeeId,
                                    @iIntSemesterId = wm.SemesterId,
                                    @iStrDayOfWork = wm.DayOfWork,
                                    @iTmTimeInAM = wm.TimeInAM == TimeSpan.Zero ? null : wm.TimeInAM,
                                    @iTmTimeOutAM = wm.TimeOutAM == TimeSpan.Zero ? null : wm.TimeOutAM,
                                    @iTmTimeInPM = wm.TimeInPM == TimeSpan.Zero ? null : wm.TimeInPM,
                                    @iTmTimeOutPM = wm.TimeOutPM == TimeSpan.Zero ? null : wm.TimeOutPM,
                                    @iTmTimeInEvening = wm.TimeInEvening == TimeSpan.Zero ? null : wm.TimeInEvening,
                                    @iTmTimeOutEvening = wm.TimeOutEvening == TimeSpan.Zero ? null : wm.TimeOutEvening
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
