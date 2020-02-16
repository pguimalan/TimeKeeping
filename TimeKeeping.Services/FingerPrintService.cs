using System.Collections.Generic;
using TimeKeeping.Data;
using TimeKeeping.Data.Interface;
using TimeKeeping.Models;
using TimeKeeping.Services.Interface;

namespace TimeKeeping.Services
{
    public class FingerPrintService : IFingerPrintService
    {
        static readonly IFingerPrintRepository _repo = new FingerPrintRepository();

        public List<FingerPrintModel> FingerPrint_ByEmpId(int employeeId)
        {
            return _repo.FingerPrint_ByEmpId(employeeId);
        }

        public void FingerPrint_Delete(FingerPrintModel fm)
        {
            _repo.FingerPrint_Delete(fm);
        }

        public void FingerPrint_Insert(FingerPrintModel fm)
        {
            _repo.FingerPrint_Insert(fm);
        }

        public List<FingerPrintModel> FingerPrint_SelectAll()
        {
            return _repo.FingerPrint_SelectAll(); ;
        }
    }
}
