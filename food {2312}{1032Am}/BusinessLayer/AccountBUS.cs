using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DataLayer;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AccountBUS
    {
        static IAccount acc_act;
        static AccountBUS()
        {
            acc_act = new Account_Act();
        }
        public static List<Accounts> GetAll()
        {
            return acc_act.GetAll();
        }


        public static void insert(string username, string password, string fistName, string lastName, string email, string phone, string address, string position,string imageURL)
        {
            acc_act.insert(username, password, fistName, lastName, email, phone, address, position,imageURL);
        }


        public static void edit(Accounts obj, int id, string fistName, string lastName, string email, string phone, string address, string position,string imageURL)
        {
            acc_act.edit(obj, id, fistName, lastName, email, phone, address, position,imageURL);
        }


        public static void delete(Accounts obj)
        {
            acc_act.delete(obj);
        }


        public static List<Accounts> searchFirstname(string firstName)
        {
            return acc_act.searchFirstname(firstName);
        }
        public static List<Accounts> searchLastname(string lastName)
        {
            return acc_act.searchLastname(lastName);
        }


        public static bool checkUsername(string username)
        {
            return acc_act.checkUsername(username);
        }


        public static List<Accounts> positionFilter(string position)
        {
            return acc_act.positionFilter(position);
        }


        public static bool checkLogin(string username, string password)
        {
            return acc_act.checkLogin(username, password);
        }


        public static bool checklevel(Accounts obj)
        {
            return acc_act.checklevel(obj);
        }
        
        public static bool checkIsLock(string username, string password)
        {
            return acc_act.checkIsLock(username,password);
        }

        public static void lock_unlockUser(int id)
        {
            acc_act.lock_unlockUser(id);
        }

        public static void changepass(string username, string newpass)
        {
            acc_act.changepass(username, newpass);
        }

        public static int GetLevel(string username, string password)
        {
            return acc_act.GetLevel(username, password);
        }
    }
}
