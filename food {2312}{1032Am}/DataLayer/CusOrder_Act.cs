using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Data.Entity;
using DataLayer;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CusOrder_Act : ICusOrder
    {
        public void changeQuantity(CusOrders obj)
        {
            using (ModelContext db = new ModelContext())
            {
                if (obj!=null)
                {
                    db.Entry<CusOrders>(obj).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }

        public bool check_DishExist(string name)
        {
            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.cusOrder_list.Any(order => order.name == name);
                if(isExist==true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void clearAll()
        {
            using (ModelContext db = new ModelContext())
            {
                foreach(CusOrders cusO in db.cusOrder_list)
                {
                    db.Entry<CusOrders>(cusO).State = EntityState.Deleted;
                }
                db.SaveChanges();
            }
        }

        public void delete(CusOrders obj)
        {
            using (ModelContext db = new ModelContext())
            {
                if(obj!=null)
                {
                    db.Entry<CusOrders>(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }

        public List<CusOrders> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.cusOrder_list.ToList();
            }
        }

        public CusOrders GetByName(string name)
        {
            using (ModelContext db = new ModelContext())
            {
                var cusOrder = db.cusOrder_list.FirstOrDefault(order => order.name == name);
                return cusOrder;
            }
        }

        public void insert(string name, double price, int numberDish, DateTime orderdate)
        {
            using (ModelContext db = new ModelContext())
            {
                db.cusOrder_list.Add(new CusOrders { name = name, price = price, numberDish = numberDish, dateOrder = orderdate });
                db.SaveChanges();
            }
        }

        public double TotalCost()
        {
            using (ModelContext db = new ModelContext())
            {
                double cost = 0;
                foreach(CusOrders cusO in db.cusOrder_list)
                {
                    cost += cusO.price * cusO.numberDish;
                }
                return cost;
            }
        }
    }
}
