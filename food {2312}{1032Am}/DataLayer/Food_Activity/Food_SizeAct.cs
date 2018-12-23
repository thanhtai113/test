using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Food_Activity
{
    public class Food_SizeAct : ISize
    {
        public bool checkName(string sizeName)
        {
            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.size_list.Any(fsi => fsi.name==sizeName);
                if(isExist)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void delete(Food_Size obj)
        {
            using (ModelContext db = new ModelContext())
            {
                
                db.Entry<Food_Size>(obj).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void edit(Food_Size obj)
        {
            using (ModelContext db = new ModelContext())
            {
                
                db.Entry<Food_Size>(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Food_Size> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.size_list.ToList();
            }
        }
        public Food_Size insert(Food_Size obj)
        {
            using (ModelContext db = new ModelContext())
            {
                db.size_list.Attach(obj);
                db.Entry<Food_Size>(obj).State = EntityState.Added;
                db.SaveChanges();
                return obj;
            }
        }

        public List<Food_Size> Search(string sizeName)
        {
            using (ModelContext db = new ModelContext())
            {
                var searchResult = from fsi in db.size_list
                                   where fsi.name.Contains(sizeName)
                                   select fsi;
                return searchResult.ToList();
            }
        }

        public List<Food_Size> showSize(int sizeID)
        {
            using (ModelContext db = new ModelContext())
            {
                var sizeResult = from siz in db.size_list
                                 where siz.Id == sizeID
                                 select siz;
                return sizeResult.ToList();
            }
        }
    }
}
