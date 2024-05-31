using JWT_JSON_WEB_TOCKEN_.Data;
using JWT_JSON_WEB_TOCKEN_.Models;

namespace JWT_JSON_WEB_TOCKEN_.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            int result = 0;
            employee.IsActive = 1;
            db.Employees.Add(employee);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int employeeId)
        {
            int result = 0;
            var model = db.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault();
            if (model != null)
            {
                model.IsActive = 0;
                result = db.SaveChanges();
                return result;
            }
            return result;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return db.Employees.Where(x => x.Id == employeeId && x.Id==1).SingleOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var model = (from emp in db.Employees
                         where emp.IsActive == 1
                         select emp).ToList();
            return model;

        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            var model = db.Employees.Where(emp => emp.Id == employee.Id).FirstOrDefault();
            if (model != null)
            {
                model.Name = employee.Name;
                model.City = employee.City;
                model.Salary = employee.Salary;
                model.IsActive = 1;
                result = db.SaveChanges();
            }
            return result;

        }
    }
}
