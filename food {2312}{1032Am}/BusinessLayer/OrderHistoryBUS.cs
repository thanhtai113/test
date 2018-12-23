using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DataLayer;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderHistoryBUS
    {
        static IOrderHistory orderHis;
        static OrderHistoryBUS()
        {
            orderHis = new OrderHistory_Act();
        }
        public static void insert()
        {
            orderHis.insert();
        }
        public static void clearAll()
        {
            orderHis.clearAll();
        }
        public static List<OrderHistorys> GetAll()
        {
            return orderHis.GetAll();
        }
    }
}
