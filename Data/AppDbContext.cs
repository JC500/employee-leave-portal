// AppDbContext is the bridge between our C# application and the database 

using EmployeeLeavePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeLeavePortal.Data;

// : means inheritance, so AppDbContext inherits from DbContext, DbContext is a class provided by Entity Framework Core
// By inheriting from it, our AppDbContext gets all the database functionality Entity Framework already provides 
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }

    // Tells the Entity Framework that we want to work with collections of Employee and LeaveRequest
    // They correspont to Employee and LeaveReuqest tables/PostgreSQL
    public DbSet<Employee> Employees { get; set; }
    public DbSet<LeaveRequest> LeaveRequests {get; set; }
}