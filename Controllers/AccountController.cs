using Microsoft.AspNetCore.Mvc;
using MVCSample.Interfaces;
using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public AccountController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = _employeeService.Authenticate(model.EmployeeNumber, model.Password);
                if (employee != null)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Employee Number သို့မဟုတ် Password မှားယွင်းနေပါသည်။");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}