using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer.Food_Activity
{
    public class Food_TypeAct : IType
    {        
        public List<Food_Type> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.type_list.ToList();
            }
        }
        public Food_Type Insert(Food_Type obj)
        {
            using (ModelContext db = new ModelContext())
            {                
                db.Entry<Food_Type>(obj).State = EntityState.Added;
                db.SaveChanges();
                return obj;
            }
        }

        public void update(Food_Type obj)
        {
            using (ModelContext db = new ModelContext())
            {
                db.type_list.Attach(obj);
                db.Entry<Food_Type>(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void delete(Food_Type obj)
        {
            using (ModelContext db = new ModelContext())
            {
                db.type_list.Attach(obj);
                db.Entry<Food_Type>(obj).State = EntityState.Deleted;                
                db.SaveChanges();
            }
        }

        public bool checkFoodType(string typename)
        {
            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.type_list.Any(type => type.nameType.Equals(typename));
                if (isExist)
                    return true;
                else
                    return false;
            }
        }

        public List<Food_Type> search(string typeName)
        {
            using (ModelContext db = new ModelContext())
            {
                var searchResult = from fty in db.type_list
                                   where fty.nameType.Contains(typeName)
                                   select fty;
                return searchResult.ToList();
            }
        }

        public List<Food_Type> showType(int typeID)
        {
            using (ModelContext db = new ModelContext())
            {
                var typeResult = from typ in db.type_list
                                 where typ.Id == typeID
                                 select typ;
                return typeResult.ToList();
            }
        }
    }
}
