using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.GenericRepo;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {

        private readonly IUnitOfWork _uow;

        public CourseController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public ActionResult Index()
        {
            var model = _uow.courserepo.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CourseTable model)
        {
            if (ModelState.IsValid)
            {
                _uow.courserepo.Insert(model);
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            CourseTable model = _uow.courserepo.GetById(id);
            return View(model);
        }
        [HttpPost]

        public ActionResult Edit(CourseTable model)
        {
            if (ModelState.IsValid)
            {
                _uow.courserepo.Update(model);
                _uow.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]

        public ActionResult Delete(int id)
        {
            CourseTable model = _uow.courserepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeletePost(int id)
        {
             _uow.courserepo.DeletePost(id);
            _uow.Save();
            return RedirectToAction("Index");
        }




















        /*
                private IRepository<CourseTable> repo = null;
                *//*private IRepository Repository { get; set; }*/

        /*public CourseController()
        {
            this.repo = new Repository<CourseTable>();
        }*//*

        public CourseController(IRepository<CourseTable>repo)
        {
            this.repo = repo; 
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CourseTable model)
        {
            if(ModelState.IsValid)
            {
                repo.Insert(model);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

       
        public ActionResult Edit(int id)
        {
            CourseTable model = repo.GetById(id);
            return View(model);
        }
                [HttpPost]

        public ActionResult Edit(CourseTable model)
        {
            if (ModelState.IsValid)
            {
                repo.Update(model);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]

        public ActionResult Delete(int id)
        {
            CourseTable model = repo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            repo.DeletePost(id);
            repo.Save();
            return RedirectToAction("Index");
        }
*/













        /* private readonly MyDbContext _db;

         public CourseController(MyDbContext db)
         {
             _db = db;
         }

         public IActionResult Index()
         {
             IEnumerable<CourseTable> CourseList = _db.CourseTable;
             return View(CourseList);
         }



         //get-create= notun course create korar jonne
         public IActionResult Create()
         {
             return View();
         }




         //post-create= create click korar por ta database a pathanor jonne
         [HttpPost]
         [ValidateAntiForgeryToken]
         public IActionResult Create(CourseTable course)
         {
             if (ModelState.IsValid)
             {
                 _db.CourseTable.Add(course);
                 _db.SaveChanges();
                 return RedirectToAction("Index");
             }
             return View(course);
         }



         //get-edit= edit course korar jonne
         public IActionResult Edit(int? id)
         {
             if (id == null || id == 0)
             {
                 return NotFound();
             }
             var obj = _db.CourseTable.Find(id);
             if (obj == null)
             {
                 return NotFound();
             }

             return View(obj);
         }



         //post-edit= edit click korar por ta database a pathanor jonne
         [HttpPost]
         [ValidateAntiForgeryToken]
         public IActionResult Edit(CourseTable course)
         {
             if (ModelState.IsValid)
             {
                 _db.CourseTable.Update(course);
                 _db.SaveChanges();
                 return RedirectToAction("Index");
             }
             return View(course);
         }


         //GET - DELETE
         public IActionResult Delete(int? id)
         {
             if (id == null || id == 0)
             {
                 return NotFound();
             }
             var obj = _db.CourseTable.Find(id);
             if (obj == null)
             {
                 return NotFound();
             }

             return View(obj);
         }

         //POST - DELETE
         [HttpPost]
         public IActionResult DeletePost(int? id)
         {
             var obj = _db.CourseTable.Find(id);
             if (obj == null)
             {
                 return NotFound();
             }
             _db.CourseTable.Remove(obj);
             _db.SaveChanges();
             return RedirectToAction("Index");
         }
 */
    }
}
