using MVCSample.Data;
using MVCSample.Data.Entities;
using MVCSample.Interfaces;

namespace MVCSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public Employee? Authenticate(int employeeNumber, string password)
        {
            return _context.Employees.FirstOrDefault(e => e.EmployeeNumber == employeeNumber && e.Password == password);
        }
    }
}
