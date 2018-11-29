using EmployeeManagment.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Shared.Orchestrators.Interfaces
{
    class IUserOrchestrator
    {
        Task<int> LoginUser(UserViewModel user);
    }
}
