using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IOrderHistory
    {
        void insert();
        void clearAll();
        List<OrderHistorys> GetAll();
    }
}
