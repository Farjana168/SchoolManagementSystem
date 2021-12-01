using SchoolManagementSystem.Data;
using SchoolManagementSystem.GenericRepo;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MyDbContext _db = null;


        public Repository<CourseTable> Courserepo;
        public Repository<StudentTable> Studentrepo;
        public Repository<TeacherTable> Teacherrepo;

        public UnitOfWork(MyDbContext db)
        {
            _db = db;

        }
        public Repository<CourseTable> courserepo
        {
            get
            {
                if (this.Courserepo == null)
                {
                    this.Courserepo = new Repository<CourseTable>(_db);
                }
                return Courserepo;
            }
           
        }
        public Repository<TeacherTable> teacherrepo
        {
            get
            {
                if (this.Teacherrepo == null)
                {
                    this.Teacherrepo = new Repository<TeacherTable>(_db);
                }
                return Teacherrepo;
            }
        }
        public Repository<StudentTable> studentrepo
        {
            get
            {
                if (this.Studentrepo == null)
                {
                    this.Studentrepo = new Repository<StudentTable>(_db);
                }
                return Studentrepo;
            }
        }

        /*public Repository<CourseTable> Course { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Repository<TeacherTable> Teacher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Repository<StudentTable> Student { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
*/
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        
    }
}
