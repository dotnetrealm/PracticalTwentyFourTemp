using Microsoft.AspNetCore.Mvc;
using PracticalTwentyFour.Application.Interfaces;
using PracticalTwentyFour.Application.Models;

namespace PracticalTwentyFour.Controllers
{
    [ApiController]
    [Route("Employee/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _employeeService.GetAllEmployeesAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _employeeService.GetEmployeeByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeModel employee)
        {
            if (!ModelState.IsValid) return BadRequest("Please enter valid employee details!");
            await _employeeService.AddEmployeeAsync(employee);
            return Ok("Employee created successfully");
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, EmployeeModel employee)
        {
            if (!ModelState.IsValid) return BadRequest("Please enter valid employee details!");
            await _employeeService.UpdateEmployeeAsync(id, employee);
            return Ok("Employee created successfully");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
            return Ok("Employee removed successfully!");
        }
    }
}
