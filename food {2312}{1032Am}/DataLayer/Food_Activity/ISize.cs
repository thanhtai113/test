using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Food_Activity
{
    public interface ISize
    {

        List<Food_Size> GetAll();
        Food_Size insert(Food_Size obj);
        void edit(Food_Size obj);
        void delete(Food_Size obj);
        bool checkName(string sizeName);
        List<Food_Size> Search(string sizeName);        
        List<Food_Size> showSize(int F_sizeID);
    }
}
