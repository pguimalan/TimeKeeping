using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Services.Interface
{
    public interface IAuthService
    {
        bool Login(string username, string password);
    }
}
