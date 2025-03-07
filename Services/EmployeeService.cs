using CompanyManagementAPI.Models;
using CompanyManagementAPI.Repositories;

namespace CompanyManagementAPI.Services {
    
    public class EmployeeService : IEmployeeService {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync() {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id) {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task CreateEmployeeAsync(Employee employee) {
            await _employeeRepository.CreateEmployeeAsync(employee);
        }

        public async Task UpdateEmployeeAsync(Employee employee) {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int id) {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }
    }
}
