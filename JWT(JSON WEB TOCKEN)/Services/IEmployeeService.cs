using JWT_JSON_WEB_TOCKEN_.Models;

namespace JWT_JSON_WEB_TOCKEN_.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int employeeId);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int DeleteEmployee(int employeeId);
    }
}
