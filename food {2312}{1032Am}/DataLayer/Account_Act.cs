using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Account_Act : IAccount
    {
        public bool checklevel(Accounts obj)
        {
            if (obj.level==1)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }
        public bool checkLogin(string username,string password)
        {

            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.account_list.Any(acc => acc.username == username && acc.password==password);                
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

        public bool checkUsername(string username)
        {
            using (ModelContext db = new ModelContext())
            {
                bool isExist = db.account_list.Any(acc => acc.username == username);
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

        public void delete(Accounts obj)
        {
            using (ModelContext db = new ModelContext())
            {
                db.Entry<Accounts>(obj).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void edit(Accounts obj, int id,string fistName, string lastName, string email, string phone, string address, string position,string imageURL)
        {
            using (ModelContext db = new ModelContext())
            {
                obj = (from acc in db.account_list
                      where acc.Id == id
                      select acc).First();
                if (obj != null)
                {
                    obj.firstname = fistName;
                    obj.lastname = lastName;
                    obj.email = email;
                    obj.phone = phone;
                    obj.address = address;
                    obj.position = position;
                    obj.imageURL = imageURL;
                    obj.level = 0;
                    obj.isLocked = false;
                    db.SaveChanges();
                }
                else
                    return;
            }
        }

        public List<Accounts> GetAll()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.account_list.ToList();
            }
        }

        public void insert(string username, string password, string fistName, string lastName, string email, string phone, string address, string position,string imageURL)
        {
            using (ModelContext db = new ModelContext())
            {
                db.account_list.Add(new Accounts { username = username, password = password, firstname = fistName, lastname = lastName, email = email, phone = phone, address = address, position = position,imageURL=imageURL, level=0,isLocked=false });
                db.SaveChanges();               
            }
        }

        public List<Accounts> positionFilter(string position)
        {
            using (ModelContext db = new ModelContext())
            {
                var resultFilter = from acc in db.account_list
                                   where acc.position == position
                                   select acc;
                return resultFilter.ToList();
            }
        }

        public List<Accounts> searchFirstname(string firstName)
        {
            using (ModelContext db = new ModelContext())
            {
                var Result  = from acc in db.account_list
                              where acc.firstname.Contains(firstName)
                              select acc;
                return Result.ToList();

            }
        }

        public List<Accounts> searchLastname(string lastName)
        {
            using (ModelContext db = new ModelContext())
            {
                var Result = from acc in db.account_list
                             where acc.lastname.Contains(lastName)
                             select acc;
                return Result.ToList();

            }
        }
        public bool checkIsLock(string username, string password)
        {
            using (ModelContext db = new ModelContext())
            {
                var obj = db.account_list.FirstOrDefault(acc => acc.username == username && acc.password == password);
                if(obj.isLocked==true)
                {
                    Console.WriteLine("lock");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void changepass(string username, string newpass)
        {
            using (ModelContext db = new ModelContext())
            {
                var accChan = db.account_list.FirstOrDefault(acc => acc.username == username);
                if(accChan!=null)
                {
                    accChan.password = newpass;
                    db.SaveChanges();
                }
                else
                {
                    return;
                }
                               
            }
        }

        public int GetLevel(string username, string password)
        {
            using (ModelContext db = new ModelContext())
            {
                var getAcc = db.account_list.FirstOrDefault(acc => acc.username == username && acc.password == password);
                return getAcc.level;
            }
        }

        public void lock_unlockUser(int id)
        {
            using (ModelContext db = new ModelContext())
            {
                var acc = db.account_list.Find(id);
                if(acc!=null)
                {
                    if(acc.isLocked==true)
                    {
                        acc.isLocked = false;
                        db.SaveChanges();
                    }
                    else
                    {
                        acc.isLocked = true;
                        db.SaveChanges();
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
