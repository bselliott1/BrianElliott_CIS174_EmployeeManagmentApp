using System;

namespace EmployeeManagment.Shared.ViewModels
{
    public class SingleEmployeeViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
