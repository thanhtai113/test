using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ICusOrder
    {
        void insert(string name, double price, int numberDish, DateTime orderdate);
        void clearAll();
        List<CusOrders> GetAll();
        double TotalCost();
        void delete(CusOrders obj);
        void changeQuantity(CusOrders obj);
        bool check_DishExist(string name);
        CusOrders GetByName(string name);
    }
}
