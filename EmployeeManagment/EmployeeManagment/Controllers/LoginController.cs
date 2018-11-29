using EmployeeManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagment.Controllers
{
    public class LoginController : Controller
    {
        private UserOrchestrator userOrchestrator = new UserOrchestrator();
public ActionResult Login()
{
    return View();
}
[HttpPost]
public ActionResult Login(LoginController user)
{
    using (EmployeeContext db = new EmployeeContext())
    {
        var loginUser = db.UserInformation.Single(u => u.UserName == user.UserName && u.Password == user.Password);

        if (loginUser != null)
        {
            Session["userId"] = loginUser.userId.ToString();
            Session["UserName"] = loginUser.UserName.ToString();
            return RedirectToAction("MyProfile");
        }
        else
        {
            ModelState.AddModelError("", "Username or Password is incorrect.");
        }
    }
    return View();
}
    }
}