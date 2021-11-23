using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherCourseStudentController : Controller
    {
        private readonly MyDbContext _db;

        public TeacherCourseStudentController(MyDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TeacherCourseStudent> TeacherCourseStudentList = _db.TeacherCourseStudentTable;
            return View(TeacherCourseStudentList);
        }



        //get-create= notun course create korar jonne
        public IActionResult Create()
        {
            return View();
        }




        //post-create= create click korar por ta database a pathanor jonne
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TeacherCourseStudent obj)
        {
            var stuid = obj.StudentId;
            var teid = obj.TeacherId;
            var couid = obj.CourseId;
            var stuobj = _db.StudentTable.Find(stuid);
            var teobj = _db.TeacherTable.Find(teid);
            var couobj = _db.CourseTable.Find(couid);
            if (teobj == null || teid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.TeacherId), "TeachetID not found in the Database");
                /*return View(obj);*/
                /* ViewBag.Error = "No such TeacherId exits";
                return RedirectToAction("Index");*/
            }
            if (stuobj == null || stuid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.StudentId), "StudentID not found in the Database");
               /* return View(obj);*/
                /*  ViewBag.Error = "No such StudentId exits";
                  return RedirectToAction ("Index");*/
            }
            if (couobj == null || couid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.CourseId), "CourseID not found in the Database");
                /*return View(obj);*/
                /*ViewBag.Error = "No such CourseId exits";
               return RedirectToAction("Index");*/
            }
            if (ModelState.IsValid)
            {
                _db.TeacherCourseStudentTable.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


/**/
        //get-edit= edit course korar jonne
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.TeacherCourseStudentTable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }



        //post-edit= edit click korar por ta database a pathanor jonne
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TeacherCourseStudent obj)
        {
            var stuid = obj.StudentId;
            var teid = obj.TeacherId;
            var couid = obj.CourseId;
            var stuobj = _db.StudentTable.Find(stuid);
            var teobj = _db.TeacherTable.Find(teid);
            var couobj = _db.CourseTable.Find(couid);
            if (teobj == null || teid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.TeacherId), "TeachetID not found in the Database");
                /*return View(obj);*/
                /* ViewBag.Error = "No such TeacherId exits";
                return RedirectToAction("Index");*/
            }
            if (stuobj == null || stuid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.StudentId), "StudentID not found in the Database");
                /* return View(obj);*/
                /*  ViewBag.Error = "No such StudentId exits";
                  return RedirectToAction ("Index");*/
            }
            if (couobj == null || couid == 0)
            {
                ModelState.AddModelError(nameof(TeacherCourseStudent.CourseId), "CourseID not found in the Database");
                /*return View(obj);*/
                /*ViewBag.Error = "No such CourseId exits";
               return RedirectToAction("Index");*/
            }
            if (ModelState.IsValid)
            {
                _db.TeacherCourseStudentTable.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.TeacherCourseStudentTable.Find(id);
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
            var obj = _db.TeacherCourseStudentTable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.TeacherCourseStudentTable.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
