using company.repositry.interfaces;
using company.repositry.repositres;
using Microsoft.AspNetCore.Mvc;

namespace company.web22.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepositry _departmentRepositry;
        //private object departmentRepositry;

        public DepartmentController(IDepartmentRepositry departmentRepositry)
        {
         _departmentRepositry = departmentRepositry;
        }
        public IActionResult Index()
        {
            var departments = _departmentRepositry.GetAll();
            return View(departments);
        }
    }
}
