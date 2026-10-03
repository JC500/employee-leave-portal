using EmployeeLeavePortal.Models;

namespace EmployeeLeavePortal.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        // If the employees table doesn't contain any employees, we add our first employee and saves it to PostgreSQL
        if (!db.Employees.Any())
        {
            var employee = new Employee
            {
                Name = "Jose Parada",
                Email = "jose@example.com",
                VacationDays = 25
            };

            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}