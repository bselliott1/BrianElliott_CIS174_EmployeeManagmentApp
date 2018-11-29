using EmployeeManagment.Domain;
using EmployeeManagment.Shared.Orchestrators.Interfaces;
using EmployeeManagment.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Shared.Orchestrators
{
    class User : IUserOrchestrator
    {
        private LoginContext _userContext;

        public User()
        {
            _userContext = new LoginContext();
        }
        public async Task<int> LoginUser(UserViewModel user)
        {
            _userContext..Add(new User
            {
                userId = user.userId,
                UserName = user.UserName,
                Password = user.Password,
            });
        }
    }
}
