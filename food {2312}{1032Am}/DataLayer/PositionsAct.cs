using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class PositionsAct : IPositions
    {
        public bool checkName(string name)
        {
            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.position_list.Any(pos => pos.positionName.Equals(name));
                if(isExist)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void delete(Positions pos)
        {
            using (ModelContext db = new ModelContext())
            {
                db.Entry<Positions>(pos).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void edit(Positions pos)
        {
            using (ModelContext db = new ModelContext())
            {
                db.Entry<Positions>(pos).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Positions> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.position_list.ToList();
            }
        }

        public Positions insert(Positions pos)
        {
            using (ModelContext db = new ModelContext())
            {
                db.Entry<Positions>(pos).State = EntityState.Added;
                db.SaveChanges();
                return pos;
            }
        }

        public List<Positions> search(string PosName)
        {
            using (ModelContext db = new ModelContext())
            {
                var searchResult = from pos in db.position_list
                                   where pos.positionName.Contains(PosName)
                                   select pos;
                return searchResult.ToList();
            }
        }
    }
}
