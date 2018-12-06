/** =========================================================

 Student Brian Elliott

 Operating System Windows 10

 Microsoft Visual Studio 2017 Enterprise

 CIS 174

 Name Of homework Assignment Employee Manager

 Program Description: program is an employee managment app that allows for the creation and ability to view current employees

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System.Web.Http;
using EmployeeManagment.Shared.Orchestrators;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagment.Shared.ViewModels;

namespace EmployeeManagment.Api.Controllers
{
    [Route("api/v1/employees")]
    public class EmployeeController : ApiController
    {
        private EmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }

        public async Task<List<AllEmployeesViewModel>> GetEmployeeFullName()
        {
            var employees = await _employeeOrchestrator.GetEmployeeFullName();

            return employees;
        }

        [AcceptVerbs("Get", "Post")]
        [HttpGet]
        [Route("api/v1/getEmployee")]
        public async Task<SingleEmployeeViewModel> getEmployeeId(string employeeId)
        {
            var employee = await _employeeOrchestrator.getEmployeeId(employeeId);

            return employee;
        }

        [HttpGet]
        [Route("api/v1/getAllEmployees")]
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();

            return employees;
        }
    }
}
