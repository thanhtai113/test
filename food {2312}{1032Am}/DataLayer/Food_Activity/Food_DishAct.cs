using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer.Food_Activity
{
    public class Food_DishAct : IDish
    {
        public bool checkName(string dishName)
        {
            using (ModelContext db = new ModelContext())
            {               
                bool isExist = db.dish_list.Any(dis => dis.name == dishName);
                if (isExist)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public void delete(Food_Dish obj)
        {
            using (ModelContext db = new ModelContext())
            {
                db.Entry<Food_Dish>(obj).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void dishLock_Unlock(int id)
        {
            using (ModelContext db = new ModelContext())
            {
                var dish = db.dish_list.Find(id);
                if(dish!=null)
                {
                    if(dish.isLock==false)
                    {
                        dish.isLock = true;
                        db.SaveChanges();
                    }
                    else
                    {
                        dish.isLock = false;
                        db.SaveChanges();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        public void edit(Food_Dish dishEdit, string E_Dname, double E_DPrice, string E_DDescription,string E_DImage, string E_DType, string E_DSize,int E_DId, int E_DStock)
        {
            using (ModelContext db = new ModelContext())
            {
                Food_Size fsi = db.size_list.FirstOrDefault(fsize => fsize.name == E_DSize);
                Food_Type ftyp = db.type_list.FirstOrDefault(typ => typ.nameType == E_DType);
                dishEdit = (from dish in db.dish_list
                            where dish.Id == E_DId
                            select dish).First();

                dishEdit.name = E_Dname;
                dishEdit.price = E_DPrice;
                dishEdit.description = E_DDescription;
                dishEdit.imaGeURL = E_DImage;
                dishEdit.TypeId = ftyp.Id;
                dishEdit.SizeId = fsi.Id;
                dishEdit.stock = E_DStock;
                db.SaveChanges();
            }
        }

        public List<Food_Dish> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.dish_list.ToList();
            }
        }
        public void insert(string DishName,double DishPrice,string DishDescription,string DishImage, string TypeName, string SizeName, int DStock)
        {
            using (ModelContext db = new ModelContext())
            {
                Food_Size fsi = db.size_list.FirstOrDefault(fsize => fsize.name == SizeName);
                Food_Type ftyp = db.type_list.FirstOrDefault(ftype => ftype.nameType == TypeName);
                db.dish_list.Add(new Food_Dish {name=DishName,price=DishPrice,description=DishDescription,imaGeURL=DishImage, TypeId=ftyp.Id, SizeId=fsi.Id, stock= DStock});
                db.SaveChanges();
            }
                
        }

        public List<Food_Dish> dish_NotLocked()
        {
            using (ModelContext db = new ModelContext())
            {
                var fd = from d in db.dish_list
                         where d.isLock == false
                         select d;
                return fd.ToList();
            }
        }

        public List<Food_Dish> search(string name)
        {
            using (ModelContext db = new ModelContext())
            {
                var searchResult = from dis in db.dish_list
                                   where dis.name.Contains(name)
                                   select dis;
                return searchResult.ToList();
            }
        }

        public List<Food_Dish> sizeFilter(int D_SizeId)
        {
            using (ModelContext db = new ModelContext())
            {
                var filterResult = from dish in db.dish_list
                                   where dish.SizeId == D_SizeId
                                   select dish;
                return filterResult.ToList();
            }
        }

        public List<Food_Dish> typeFilter(int D_TypeId)
        {
            using (ModelContext db = new ModelContext())
            {
                var filterResult = from dish in db.dish_list
                                   where dish.TypeId == D_TypeId
                                   select dish;
                return filterResult.ToList();
            }
        }

        public void uploadImage(Food_Dish obj)
        {
            using (ModelContext db = new ModelContext())
            {
                
            }
        }

        public void stockCalulate(int id, int numberDish, bool change)
        {
            using (ModelContext db = new ModelContext())
            {
                if(change==true)
                {
                    var fd = db.dish_list.Find(id);
                    fd.stock = fd.stock - numberDish;
                    db.SaveChanges();
                }
                else
                {
                    var fd = db.dish_list.Find(id);
                    fd.stock = fd.stock + numberDish;
                    db.SaveChanges();
                }
            }
        }
        public Food_Dish GetByName(string DName)
        {
            using (ModelContext db = new ModelContext())
            {
                var fd = db.dish_list.FirstOrDefault(dish => dish.name == DName);
                return fd;
            }
        }
    }
}
