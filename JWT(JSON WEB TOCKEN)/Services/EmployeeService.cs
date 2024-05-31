using JWT_JSON_WEB_TOCKEN_.Models;
using JWT_JSON_WEB_TOCKEN_.Repositories;

namespace JWT_JSON_WEB_TOCKEN_.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int employeeId)
        {
            return repo.DeleteEmployee(employeeId);
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return repo.GetEmployeeById(employeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
