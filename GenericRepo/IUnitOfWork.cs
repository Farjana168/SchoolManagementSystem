using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.GenericRepo
{
    public interface IUnitOfWork
    {
        Repository<CourseTable> courserepo { get;  }
        Repository<TeacherTable> teacherrepo { get;  }
        Repository<StudentTable> studentrepo { get;  }

        void Save();
        void Dispose();
    }
}
