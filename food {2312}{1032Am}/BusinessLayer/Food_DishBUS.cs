using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Food_Activity;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Food_DishBUS
    {
        static IDish dish_act;        
        static Food_DishBUS()
        {
            dish_act = new Food_DishAct();            
        }
        public static List<Food_Dish> GetAll()
        {
            return dish_act.GetAll();
        }
        public static void insert(string DishName, double DishPrice, string DishDescription, string DishImage, string TypeName, string SizeName, int DStock)
        {
            dish_act.insert(DishName,DishPrice, DishDescription, DishImage,TypeName,SizeName,DStock);
        }
        public static void delete (Food_Dish Fdish)
        {
            dish_act.delete(Fdish);
        }
        public static List<Food_Dish> search(string F_DName)
        {
            return dish_act.search(F_DName);
        }
        public static bool chekName( string F_D_name)
        {
            return dish_act.checkName(F_D_name);
        }
        public static void edit(Food_Dish dishEdit, string E_Dname, double E_DPrice, string E_DDescription, string E_DImage, string E_DType, string E_DSize, int E_DId, int E_DStock)
        {
            dish_act.edit(dishEdit,E_Dname,E_DPrice,E_DDescription,E_DImage,E_DType,E_DSize,E_DId,E_DStock);
        }
        public static List<Food_Dish> D_TypeFilter(int typeId)
        {
            
            return dish_act.typeFilter(typeId);
        }
        public static List<Food_Dish> D_SizeFilter(int sizeId)
        {
            
            return dish_act.sizeFilter(sizeId);
        }
        public static void dishLock_Unlock(int id)
        {
            dish_act.dishLock_Unlock(id);
        }
        public static List<Food_Dish> dish_NotLocked()
        {
            return dish_act.dish_NotLocked();
        }
        public static void stockCalulate(int id, int numberDish, bool change)
        {
            dish_act.stockCalulate(id, numberDish,change);
        }
        public static Food_Dish GetByName(string DName)
        {
            return dish_act.GetByName(DName);
        }
    }
}
