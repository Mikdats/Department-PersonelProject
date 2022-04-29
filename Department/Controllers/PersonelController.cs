using DepartmentExample.Models.Dto;
using DepartmentProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DepartmentExample.Controllers
{
    [Authorize]
    public class PersonelController : Controller
    {
        Context c = new Context();
       
        public IActionResult Index()
        {
            var result = (from p in c.Personels
                         join d in c.Departments
                         on p.DepartId equals d.DepartId
                         select new PersonelViewDto
                         {
                             PersonelId = p.PersonelId,
                             Name = p.Name,
                             Surname = p.Surname,
                             City = p.City,
                             DepartName = d.DepartmentName
                         }).ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult NewPersonel()
        {
            List<SelectListItem> degerler=(from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.DepartmentName,
                                               Value=x.DepartId.ToString()
                                           }).ToList();
            ViewBag.dgr=degerler;
            return View();  
        }
        [HttpPost]
        public IActionResult NewPersonel(Personel p)
        {
            var personel = c.Departments.Where(x => x.DepartId == p.DepartId).SingleOrDefault();
            p.Department = personel;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeletePersonel(int id)
        {
            var personel = c.Personels.FirstOrDefault(x => x.PersonelId == id);
            c.Personels.Remove(personel);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdatePersonel(int id)
        {
            var personel = c.Personels.Find(id);
            return View("UpdatePersonel", personel);
        }

        public IActionResult UpdatedPersonel(Personel p)
        {
            var personel = c.Personels.Find(p.PersonelId);
            personel.Name = p.Name;
            personel.Surname = p.Surname;
            personel.City = p.City;

            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
