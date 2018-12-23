using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderHistory_Act : IOrderHistory
    {
        public void clearAll()
        {
            using (ModelContext db = new ModelContext())
            {
                foreach(OrderHistorys od in db.orderHistory_list)
                {
                    db.Entry<OrderHistorys>(od).State = EntityState.Deleted;                    
                }
                db.SaveChanges();
            }
        }

        public List<OrderHistorys> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.orderHistory_list.ToList();
            }
        }

        public void insert()
        {
            using (ModelContext db = new ModelContext())
            {
                foreach(CusOrders cusO in db.cusOrder_list)
                {
                    db.orderHistory_list.Add(new OrderHistorys { name = cusO.name, price = cusO.price, numberDish = cusO.numberDish, dateOrder = cusO.dateOrder });                                      
                }
                db.SaveChanges();
            }
        }
    }
}
