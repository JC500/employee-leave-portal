namespace EmployeeLeavePortal.Models; // Tells C# which logical group this class belongs to, so the full name of our class is technically EmployeeLeavePortal.Models.Employee
public class Employee
{
    public int Id {get; set; }
    public string Name { get; set; } = string.Empty; // string.Empty gives it an initial empty string instead of null
    public string Email { get; set; } = string.Empty;

    public int VacationDays { get; set; } 

    public List<LeaveRequest> LeaveRequests { get; set; } = [];
}
