using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson.Controllers
{
    [Route("api/Emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Farjana", Department = "IT", Salary = 75000 },
            new Employee { EmployeeId = 2, Name = "Priya", Department = "HR", Salary = 65000 },
            new Employee { EmployeeId = 3, Name = "Rahul", Department = "Finance", Salary = 80000 },
            new Employee { EmployeeId = 4, Name = "Sara", Department = "IT", Salary = 70000 },
            new Employee { EmployeeId = 5, Name = "Amit", Department = "HR", Salary = 60000 }
        };

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
                return NotFound("Employee not found!");
            return Ok(employee);
        }
    }
}