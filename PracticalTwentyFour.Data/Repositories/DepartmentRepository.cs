using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Data.Contexts;
using PracticalTwentyFour.Data.Entities;
using PracticalTwentyFour.Data.Interfaces;

namespace PracticalTwentyFour.Data.Repositories;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly ApplicationDbContext _dbContext;

    public DepartmentRepository(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public async Task<Department> GetDepartmentByIdAsync(int id)
    {
        Department department = await _dbContext.Departments.FirstAsync(x => x.Id == id);
        return department;
    }
    public async Task<Department> GetDepartmentByNameAsync(string name)
    {
        Department department = await _dbContext.Departments.FirstAsync(x => x.Name == name);
        return department;
    }
}
