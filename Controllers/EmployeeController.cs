﻿using CompanyManagementAPI.Models;
using CompanyManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagementAPI.Controllers {
    
    [Route("api/[controller]"), ApiController]
    public class EmployeeController : ControllerBase {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees() {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id) {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if (employee == null) {
                return NotFound();
            }
            
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee) {
            await _employeeService.CreateEmployeeAsync(employee);
            
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee) {
            if (id != employee.Id) {
                return BadRequest();
            }
            
            await _employeeService.UpdateEmployeeAsync(employee);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id) {
            await _employeeService.DeleteEmployeeAsync(id);
            
            return NoContent();
        }
    }
}