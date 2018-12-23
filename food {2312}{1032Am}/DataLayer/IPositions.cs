using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPositions
    {
        List<Positions> GetAll();
        Positions insert(Positions pos);
        void edit(Positions pos);
        void delete(Positions pos);
        List<Positions> search(string PosName);
        bool checkName(string name);
    }
}
