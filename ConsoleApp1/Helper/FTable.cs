using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Helper
{
    class FTable<T> where T: class, IEntity
    {
        public List<T> Podaci { get; set; }
        private int Seed = 0;


        public FTable() // constructor must be public so we can  create objects outside of this class
        {
            Podaci = new List<T>();
        }

        public List<T> GetAll() 
        {
            List<T> notDeleted = new List<T>();
            foreach (var item in Podaci)
            {
                if (!item.IsDeleted)
                    notDeleted.Add(item);
            }
            return notDeleted;
        }

        public T GetById(int ID)
        {
            foreach (T item in Podaci)
            {
                if (item.Id == ID)      // in order access Id, we need to set constraint on a class FTable that only IEntity interface or types that implement this interface can be used as the type T
                    return item;
            }

            return null;    // Cannot return null for the T type because T could be a struct (which is not nullable), so we have to set constraint on a class FTable that T must be a class
        }

        public void Insert(T t)
        {
            t.Id = ++Seed;
            Podaci.Add(t);
        }

        public void Delete(T t) 
        {
            Podaci.Remove(t);
        }
        public void Update(T t)
        {
            Delete(t);
            Insert(t);
        }
    }
}
