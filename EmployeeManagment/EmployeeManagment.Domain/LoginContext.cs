using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain
{
    public class LoginContext : DbContext
    {
        public DbSet<User> UserInformation { get; set; }
    }

}
