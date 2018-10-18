function searchEmployee() {
    var search = $("#searchString").val().trim();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        $("#employeeId").val(data.EmployeeId);
        $("#employeeLastName").val(data.LastName);
        $("#employeeMiddleName").val(data.MiddleName);
        $("#employeeFirstName").val(data.FirstName);
        $("#employeeBirthDate").val(data.BirthDate);
        $("#employeeHireDate").val(data.HireDate);
        $("#employeeDepartment").val(data.Department);
        $("#employeeJobTitle").val(data.JobTitle);
        $("#employeePayRate").val(data.PayRate);
        $("#employeeAvailableHours").val(data.AvailableHours);
    });
}

function updateEmployee() {
   var employeeId = $("#employeeId").val();
   var firstName = $("#employeeLastName").val();
   var middleName = $("#employeeMiddleName").val();
   var lastName = $("#employeeFirstName").val();
   var birthDate = $("#employeeBirthDate").val();
   var hireDate = $("#employeeHireDate").val();
   var department = $("#employeeDepartment").val();
   var jobTitle = $("#employeeJobTitle").val();
   var payRate = $("#employeePayRate").val();
   var availableHours = $("#employeeAvailableHours").val();

    $.ajax({
        url: "UpdateEmployee",
        dataType: "Json",
        data: {
            EmployeeId: employeeId,
            FirstName: firstName,
            MiddleName: middleName,
            LastName: lastName,
            BirthDate: birthDate,
            HireDate: hireDate,
            Department: department,
            JobTitle: jobTitle,
            PayRate: payRate,
            AvailableHours: availableHours
        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    });
}