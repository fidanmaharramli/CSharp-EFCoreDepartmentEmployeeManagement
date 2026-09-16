using MyProject.Entity.Entities;
using MyProject.Entity.Entities.Common;
public class Employee : AuditEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
