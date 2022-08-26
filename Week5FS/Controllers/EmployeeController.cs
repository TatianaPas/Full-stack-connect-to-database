using Microsoft.AspNetCore.Mvc;
using Week5FS.Data;
using Week5FS.Models;

namespace Week5FS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext employeeDbContext;
        public EmployeeController(EmployeeDbContext empDbContext)
        {
            this.employeeDbContext = empDbContext;
        }
       
    
        public IActionResult Index()
        {
            var employees = employeeDbContext.Employees.ToList();
            return View(employees);
        }

        public IActionResult Delete(int id)
        {
            Employee emp = employeeDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if(emp != null)
            {
                employeeDbContext.Employees.Remove(emp);
                employeeDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Create()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            var employee = new Employee()
            {
                Name = emp.Name,
                Email = emp.Email,
                Salary = emp.Salary,
                DateOfBirth = emp.DateOfBirth,
                Department = emp.Department
            };
            employeeDbContext.Employees.Add(employee);
            employeeDbContext.SaveChanges();
            return RedirectToAction("Index");
            
        }

    }
}
