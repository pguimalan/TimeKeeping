using HRIS.Data.Interface;
using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public class DepartmentRepository : DataManager, IDepartmentRepository
    {
        public void Department_Insert(DepartmentForInsertModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Department_Insert",
                                new
                                {
                                    @iStrDeptName = ad.DepartmentName
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Department_Update(DepartmentForEditModel ad)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    con.Execute("dbo.Usp_Department_Update",
                                new
                                {
                                    @iIntDeptId = ad.DepartmentId,
                                    @iStrDeptName = ad.DepartmentName
                                }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DepartmentForListModel> Department_Select(string search)
        {
            try
            {
                using (var con = GetDbConnection())
                {
                    var result = con.Query<DepartmentForListModel>("dbo.Usp_Department_Select",
                                  new { @iStrSearch = search },
                                  commandType: CommandType.StoredProcedure);

                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
