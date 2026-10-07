namespace My_Project.Business.Services.Implemntations;

internal class DepartmentService
{
    public readonly MyProjectContext _context;

    public DepartmentService(MyProjectContext context)
    {
        _context = context;
    }
    public async Task<Department> CreateAsync(Department department)
    {
        department.CreatedAt = DateTime.UtcNow;
        department.UpdatedAt = null;

        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
        return department;
    }
    public async Task<List<Department>> GetAllAsync()
    {
        return await _context.Departments
            .AsNoTracking()
            .ToListAsync();
    }
    
    public async Task<Department?> GetByIdAsync(int id)
    {
        return await _context.Departments
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }















}
