using PracticalTwentyFour.Data.Entities;

namespace PracticalTwentyFour.Data.Interfaces;

public interface IDepartmentRepository
{
    /// <summary>
    /// Return department information by Id
    /// </summary>
    /// <param name="id">Department Id</param>
    /// <returns></returns>
    Task<Department> GetDepartmentByIdAsync(int id);

    /// <summary>
    /// Return department information by name of department
    /// </summary>
    /// <param name="name">Department name</param>
    /// <returns></returns>
    Task<Department> GetDepartmentByNameAsync(string name);
}