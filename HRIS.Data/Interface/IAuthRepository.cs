using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data.Interface
{
    public interface IAuthRepository
    {
        bool Login(string username, string password);
    }
}
