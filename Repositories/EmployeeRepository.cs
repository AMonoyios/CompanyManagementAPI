using CompanyManagementAPI.Data;
using CompanyManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementAPI.Repositories {
    
    public class EmployeeRepository : IEmployeeRepository {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync() {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id) {
            return await _context.Employees.FindAsync(id);
        }

        public async Task CreateEmployeeAsync(Employee employee) {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee) {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int id) {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null) {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
    }
}
