using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.GenericRepo
{
    public interface IRepository <T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        T Delete(object id);
        void DeletePost(object id);
        void Save();
    }
}
