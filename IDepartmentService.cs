using System;
using System.Collections.Generic;
using System.Text;

namespace My_Project.Business.Services
{
    public interface IDepartmentService
    {
        Task<Department> CreateAsync(Department department);
        Task<bool> DeleteAsync(int id);
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(int id, Department department);

    }
}
