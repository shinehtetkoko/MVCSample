using MVCSample.Data.Entities;

namespace MVCSample.Interfaces
{
    public interface IEmployeeService
    {
        // EmployeeNumber နဲ့ Password သုံးပြီး User ကို ရှာဖွေပေးမည့် Method
        Employee? Authenticate(int employeeNumber, string password);
    }
}
