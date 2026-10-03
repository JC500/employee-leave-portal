namespace EmployeeLeavePortal.Models;
public class LeaveRequest
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }

    public Employee? Employee { get; set; }

    public string Type { get; set; } = string.Empty;

    public DateOnly StartDate { get; set; } // DateTime is a built-in .NET type for representing dates and times 

    public DateOnly EndDate { get; set; }

    public string Comment { get; set; } = string.Empty;

    public string Status { get; set; } = "Pending"; 
}