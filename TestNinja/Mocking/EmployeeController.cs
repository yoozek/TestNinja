using Microsoft.EntityFrameworkCore;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage _employeeStorage;

        public EmployeeController(IEmployeeStorage storage)
        {
            _employeeStorage = storage ?? new EmployeeStorage();    
        }
        
        public ActionResult DeleteEmployee(int id)
        {
            _employeeStorage.DeleteEmployee(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }
    
    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}