using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.GenericRepo
{
    public class Repository <T> : IRepository<T> where T : class
    {
        private readonly MyDbContext _db = null;
        public DbSet<T> table = null;

        public Repository()
        {
            this._db = new MyDbContext();
            table = _db.Set<T>();
        }

        public Repository(MyDbContext db)
        {
            this._db = db;
            table = _db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {

            table.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
        }
        public T Delete(object id)
        {
            return table.Find(id);
        }
        public void DeletePost(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
