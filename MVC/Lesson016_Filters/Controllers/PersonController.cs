using Lesson016_Filters.Entities;
using Lesson016_Filters.Filters.ActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson016_Filters.Controllers
{
    [TypeFilter(typeof(PersonActionFilter))]
    public class PersonController : Controller
    {
        Person person;
        public PersonController()
        {
            person = new Person
            {
                Id = 1,
                Name = "name",
                Surname = "surname",
                Addres = "addres",
                Email = "email@email"
            };
        }
        // GET: PersonController
        //[TypeFilter(typeof(PersonActionFilter))]
        [TypeFilter(typeof(PersonArgActionFilter),Arguments = new object[] {"customkey","customvalue"})]
        public ActionResult Index()
        {

           

            return View(person);
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            return View(person);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
