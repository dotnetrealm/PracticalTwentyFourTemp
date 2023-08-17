using Microsoft.EntityFrameworkCore;
using PracticalTwentyFour.Application.Interfaces;
using PracticalTwentyFour.Application.Models;
using PracticalTwentyFour.Data.Entities;
using PracticalTwentyFour.Data.Interfaces;

namespace PracticalTwentyTwo.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<List<EmployeeModel>> GetAllEmployeesAsync()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            IQueryable<Employee> emp = _employeeRepository.GetAllEmployeeAsync();
            await emp.Include(x => x.Department).ForEachAsync(emp => employees.Add(new EmployeeModel
            {
                Id = emp.Id,
                Department = emp.Department.Name,
                Name = emp.Name,
                EmailAddress = emp.EmailAddress,
                IsDeleted = emp.IsDeleted,
                JoiningDate = emp.JoiningDate,
                Salary = emp.Salary
            }));

            return employees;
        }

        public async Task<EmployeeModel> GetEmployeeByIdAsync(int id)
        {
            Employee emp = await _employeeRepository.GetEmployeeByIdAsync(id);
            EmployeeModel employeeModel = new EmployeeModel
            {
                Id = emp.Id,
                Department = emp.Department.Name,
                Name = emp.Name,
                EmailAddress = emp.EmailAddress,
                IsDeleted = emp.IsDeleted,
                JoiningDate = emp.JoiningDate,
                Salary = emp.Salary
            };
            return employeeModel;
        }

        public async Task AddEmployeeAsync(EmployeeModel employee)
        {
            Department department = await _departmentRepository.GetDepartmentByNameAsync(employee.Department);
            await _employeeRepository.CreateEmployeeAsync(new Employee
            {
                DepartmentId = department.Id,
                Name = employee.Name,
                EmailAddress = employee.EmailAddress,
                IsDeleted = employee.IsDeleted,
                JoiningDate = employee.JoiningDate,
                Salary = employee.Salary
            });
        }

        public async Task UpdateEmployeeAsync(int id, EmployeeModel employee)
        {
            Department department = await _departmentRepository.GetDepartmentByNameAsync(employee.Department);
            Employee emp = new()
            {
                Id = id,
                DepartmentId = department.Id,
                Name = employee.Name,
                EmailAddress = employee.EmailAddress,
                IsDeleted = employee.IsDeleted,
                JoiningDate = employee.JoiningDate,
                Salary = employee.Salary
            };
            await _employeeRepository.UpdateEmployeeAsync(id, emp);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }
    }
}
