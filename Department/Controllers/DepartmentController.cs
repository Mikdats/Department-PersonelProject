using Microsoft.AspNetCore.Mvc;
using DepartmentProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace DepartmentExample.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var result=c.Departments.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult NewDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDepartment(Department department)
        {
            c.Departments.Add(department);
            c.SaveChanges();
            return RedirectToAction("Index");        
        }
        public IActionResult DeleteDepartment(int id)
        {
            var department = c.Departments.FirstOrDefault(x => x.DepartId == id);
            c.Departments.Remove(department);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateDepartment(int id)
        {
            var department=c.Departments.Find(id); 
            return View("UpdateDepartment",department);
        }
        
        public IActionResult UpdatedDepartment(Department d)
        {
            var department = c.Departments.Find(d.DepartId);
            department.DepartmentName=d.DepartmentName;
            c.SaveChanges();
            return RedirectToAction("Index");     
        }
        public IActionResult DepartmentDetail(int id)
        {
            var deger=c.Personels.Where(x=>x.DepartId==id).ToList();
            var birimad=c.Departments.Where(x=>x.DepartId==id).Select(y=>y.DepartmentName).FirstOrDefault();
            ViewBag.birimad=birimad;
            return View(deger);
        }
    }
}
