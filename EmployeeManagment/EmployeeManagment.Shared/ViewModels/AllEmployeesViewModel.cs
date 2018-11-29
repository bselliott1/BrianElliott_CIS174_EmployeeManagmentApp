using System;

namespace EmployeeManagment.Shared.ViewModels
{
    public class AllEmployeesViewModel
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
