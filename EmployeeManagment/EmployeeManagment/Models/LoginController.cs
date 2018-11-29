using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagment.Models
{
    public class LoginController : Controller
    {
        public Guid LoginId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}