using PracticalTwentyFour.Application.Models;

namespace PracticalTwentyFour.Application.Interfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Return list of all active employees
        /// </summary>
        /// <returns></returns>
        Task<List<EmployeeModel>> GetAllEmployeesAsync();

        /// <summary>
        /// Return specific employee by Id
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns></returns>
        Task<EmployeeModel> GetEmployeeByIdAsync(int id);

        /// <summary>
        /// Create new employee
        /// </summary>
        /// <param name="employee">Employee model</param>
        /// <returns></returns>
        Task AddEmployeeAsync(EmployeeModel employee);

        /// <summary>
        /// Update exisiting employee details
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <param name="employee">Employee model</param>
        /// <returns></returns>
        Task UpdateEmployeeAsync(int id, EmployeeModel employee);

        /// <summary>
        /// Delete employee(Soft delete)
        /// </summary>
        /// <param name="id">Employee Id</param>
        /// <returns></returns>
        Task DeleteEmployeeAsync(int id);
    }
}