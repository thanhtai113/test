using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DataLayer;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CusOrderBUS
    {
        static ICusOrder cusOder;
        static CusOrderBUS()
        {
            cusOder = new CusOrder_Act();
        }
        public static void insert(string name, double price, int numberDish, DateTime orderdate)
        {
            cusOder.insert(name, price, numberDish, orderdate);
        }
        public static void clearAll()
        {
            cusOder.clearAll();
        }
        public static List<CusOrders> GetAll()
        {
            return cusOder.GetAll();
        }
        public static double TotalCost()
        {
            return cusOder.TotalCost();
        }
        public static void delete(CusOrders obj)
        {
            cusOder.delete(obj);
        }
        public static void changeQuantity(CusOrders obj)
        {
            cusOder.changeQuantity(obj);
        }
        public static bool check_DishExist(string name)
        {
            return cusOder.check_DishExist(name);
        }
        public static CusOrders GetByName(string name)
        {
            return cusOder.GetByName(name);
        }
    }
}
