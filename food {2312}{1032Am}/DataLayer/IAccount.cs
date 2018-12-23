using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IAccount
    {
        List<Accounts> GetAll();
        void insert(string username, string password, string fistName, string lastName,string email,string phone,string address,string position,string imageURL );
        void edit(Accounts obj, int id, string fistName, string lastName, string email, string phone, string address, string position,string imageURL);
        void delete(Accounts obj);
        void changepass(string username, string newpass);
        List<Accounts> searchFirstname(string firstName);
        List<Accounts> searchLastname(string lastName);
        bool checkUsername(string username);
        List<Accounts> positionFilter(string position);      
        
        bool checkLogin(string username,string password);
        bool checklevel(Accounts obj);
        bool checkIsLock(string username, string password);

        void lock_unlockUser(int id);

        int GetLevel(string username, string password);
    }
}
