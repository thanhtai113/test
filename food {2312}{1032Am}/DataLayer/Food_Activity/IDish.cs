using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Food_Activity
{
    public interface IDish
    {
        List<Food_Dish> GetAll();
        void insert(string DName, double DPrice,string DDescritption,string DImage, string TypeName, string SizeName, int DStock);
        void edit(Food_Dish dishEdit,string E_Dname, double E_DPrice, string E_DDescription,string E_DImage, string E_DType, string E_DSize, int E_DId, int E_DStock);
        void delete(Food_Dish obj);
        bool checkName(string dishName);
        List<Food_Dish> search(string name);
        void uploadImage(Food_Dish obj);
        List<Food_Dish> typeFilter(int D_TypeId);
        List<Food_Dish> sizeFilter(int D_SizeId);
        void dishLock_Unlock(int id);
        List<Food_Dish> dish_NotLocked();
        void stockCalulate(int id,int numberDish,bool change);
        Food_Dish GetByName(string DName);
    }
}
