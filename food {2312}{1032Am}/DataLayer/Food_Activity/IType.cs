using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace DataLayer.Food_Activity
{
    public interface IType
    {
        List<Food_Type> GetAll(); 

        Food_Type Insert(Food_Type obj);
        void update(Food_Type obj);
        void delete(Food_Type obj);
        bool checkFoodType(string typename);
        List<Food_Type> search(string typeName);
        List<Food_Type> showType(int F_typeID);
    }
}
