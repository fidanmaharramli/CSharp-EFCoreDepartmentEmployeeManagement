namespace My_Project.Business.Services.Implemntations;

internal class DepartmentService
{
    public readonly MyProjectContext _context;

    public DepartmentService(MyProjectContext context)
    {
        _context = context;
    }
    // CREATE
    public async Task<Department> CreateAsync(Department department)
    {
        department.CreatedAt = DateTime.UtcNow;
        department.UpdatedAt = null;

        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
        return department;
    }
    // READ-Get All
    public async Task<List<Department>> GetAllAsync()
    {
        return await _context.Departments
            .AsNoTracking()
            .ToListAsync();
    }
    /// <summary>
    /// Gets a department by its ID.
    /// </summary>
    ///<param name="id"></param>
    ///<returns></returns>>
    public async Task<Department?> GetByIdAsync(int id)
    {
        return await _context.Departments
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }















}
