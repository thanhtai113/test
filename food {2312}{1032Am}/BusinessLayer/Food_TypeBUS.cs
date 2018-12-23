using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Food_Activity;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Food_TypeBUS
    {
        static IType tye_act;
        static Food_TypeBUS()
        {
            tye_act = new Food_TypeAct();
        }
        public static List<Food_Type> GetAll()
        {
            return tye_act.GetAll();
        }
        public static bool checkFoodType(string typename)
        {
            return tye_act.checkFoodType(typename);
        }
        public static Food_Type Insert(Food_Type obj)
        {
            return tye_act.Insert(obj);
        }
        public static void update(Food_Type obj)
        {
            tye_act.update(obj);
        }
        public static void delete(Food_Type obj)
        {
            tye_act.delete(obj);
        }
        public static List<Food_Type> search(string typeName)
        {
            return tye_act.search(typeName);
        }
        public static List<Food_Type> showType(int Result_typeID)
        {
            return tye_act.showType(Result_typeID);
        }
    }
}
