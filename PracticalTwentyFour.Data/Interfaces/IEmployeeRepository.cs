using PracticalTwentyFour.Data.Entities;

namespace PracticalTwentyFour.Data.Interfaces;
public interface IEmployeeRepository
{
    /// <summary>
    /// Create new employee
    /// </summary>
    /// <param name="employee">Employee entity</param>
    /// <returns></returns>
    Task CreateEmployeeAsync(Employee employee);

    /// <summary>
    /// Delete employee (soft delete)
    /// </summary>
    /// <param name="id">Employee ID</param>
    /// <returns></returns>
    Task DeleteEmployeeAsync(int id);

    /// <summary>
    /// Return all employees
    /// </summary>
    /// <returns></returns>
    IQueryable<Employee> GetAllEmployeeAsync();

    /// <summary>
    /// Retrive specific employee details by ID
    /// </summary>
    /// <param name="id">Employee ID</param>
    /// <returns></returns>
    Task<Employee> GetEmployeeByIdAsync(int id);

    /// <summary>
    /// Update employee details
    /// </summary>
    /// <param name="id">Employee ID</param>
    /// <param name="employee">Employee entity</param>
    /// <returns></returns>
    Task UpdateEmployeeAsync(int id, Employee employee);
}
