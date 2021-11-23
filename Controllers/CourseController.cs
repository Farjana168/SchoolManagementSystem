using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly MyDbContext _db;

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

    }
}
