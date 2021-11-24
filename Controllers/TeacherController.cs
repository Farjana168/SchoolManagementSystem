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
    public class TeacherController : Controller
    {


        private IRepository<TeacherTable> repo = null;
        /*private IRepository Repository { get; set; }*/

        /*public CourseController()
        {
            this.repo = new Repository<CourseTable>();
        }*/

        public TeacherController(IRepository<TeacherTable> repo)
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
        public ActionResult Create(TeacherTable model)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(model);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            TeacherTable model = repo.GetById(id);
            return View(model);
        }

        [HttpPost]

        public ActionResult Edit(TeacherTable model)
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
            TeacherTable model = repo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult DeletePost(int id)
        {
            repo.DeletePost(id);
            repo.Save();
            return RedirectToAction("Index");
        }














        /*
                private readonly MyDbContext _db;

                public TeacherController(MyDbContext db)
                {
                    _db = db;
                }

                public IActionResult Index()
                {
                    IEnumerable<TeacherTable> TeacherList = _db.TeacherTable;
                    return View(TeacherList);
                }



                //get-create= notun course create korar jonne
                public IActionResult Create()
                {
                    return View();
                }




                //post-create= create click korar por ta database a pathanor jonne
                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Create(TeacherTable teacher)
                {
                    if (ModelState.IsValid)
                    {
                        _db.TeacherTable.Add(teacher);
                        _db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(teacher);
                }



                //get-edit= edit course korar jonne
                public IActionResult Edit(int? id)
                {
                    if (id == null || id == 0)
                    {
                        return NotFound();
                    }
                    var obj = _db.TeacherTable.Find(id);
                    if (obj == null)
                    {
                        return NotFound();
                    }

                    return View(obj);
                }



                //post-edit= edit click korar por ta database a pathanor jonne
                [HttpPost]
                [ValidateAntiForgeryToken]
                public IActionResult Edit(TeacherTable teacher)
                {
                    if (ModelState.IsValid)
                    {
                        _db.TeacherTable.Update(teacher);
                        _db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(teacher);
                }


                //GET - DELETE
                public IActionResult Delete(int? id)
                {
                    if (id == null || id == 0)
                    {
                        return NotFound();
                    }
                    var obj = _db.TeacherTable.Find(id);
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
                    var obj = _db.TeacherTable.Find(id);
                    if (obj == null)
                    {
                        return NotFound();
                    }
                    _db.TeacherTable.Remove(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }*/

    }
}
