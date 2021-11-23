using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly MyDbContext _db;

        public StudentController(MyDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<StudentTable> StudentList = _db.StudentTable;
            return View(StudentList);
        }



        //get-create= notun course create korar jonne
        public IActionResult Create()
        {
            return View();
        }




        //post-create= create click korar por ta database a pathanor jonne
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentTable student)
        {
            if (ModelState.IsValid)
            {
                _db.StudentTable.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }



        //get-edit= edit course korar jonne
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.StudentTable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }



        //post-edit= edit click korar por ta database a pathanor jonne
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StudentTable student)
        {
            if (ModelState.IsValid)
            {
                _db.StudentTable.Update(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }


        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.StudentTable.Find(id);
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
            var obj = _db.StudentTable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.StudentTable.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
