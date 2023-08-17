using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Data.Contexts;
using PracticalTwentyFour.Data.Entities;
using PracticalTwentyFour.Data.Interfaces;

namespace PracticalTwentyTwo.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IQueryable<Employee> GetAllEmployeeAsync()
        {
            return _dbContext.Employees.Where(x => !x.IsDeleted).AsQueryable();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _dbContext.Employees.Include(x => x.Department).FirstAsync(x => x.Id == id && !x.IsDeleted);
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            Employee emp = (await _dbContext.Employees.FindAsync(id))!;
            emp.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(int id, Employee employee)
        {
            Employee emp = await _dbContext.Employees.FirstAsync(x => x.Id == id);
            emp.IsDeleted = employee.IsDeleted;
            emp.Name = employee.Name;
            emp.JoiningDate = employee.JoiningDate;
            emp.DepartmentId = employee.DepartmentId;
            emp.Salary = employee.Salary;
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
