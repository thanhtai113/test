using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Food_Activity;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Food_SizeBUS
    {
        static ISize size_act;
        static Food_SizeBUS()
        {
            size_act = new Food_SizeAct();
        }
        public static List<Food_Size> GetAll()
        {
            return size_act.GetAll();
        }
        public static bool checkName(string sizeName)
        {
            return size_act.checkName(sizeName);
        }
        public static Food_Size insert(Food_Size obj)
        {
            return size_act.insert(obj);
        }
        public static void edit(Food_Size obj)
        {
            size_act.edit(obj);
        }
        public static void delete (Food_Size obj)
        {
            size_act.delete(obj);
        }
        public static List<Food_Size> search(string sizeName)
        {
            return size_act.Search(sizeName);
        }

        public static List<Food_Size> showSize(int Result_sizeID)
        {
            return size_act.showSize(Result_sizeID);
        }
    }
}
