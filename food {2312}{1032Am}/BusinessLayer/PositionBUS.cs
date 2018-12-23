using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DataLayer;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class PositionBUS
    {
        static IPositions pos_act;
        static PositionBUS()
        {
            pos_act = new PositionsAct();
        }
        public static List<Positions> GetAll()
        {
            return pos_act.GetAll();
        }
        public static Positions insert(Positions pos)
        {
            return pos_act.insert(pos);
        }
        public static void edit(Positions pos)
        {
            pos_act.edit(pos);
        }
        public static void delete(Positions pos)
        {
            pos_act.delete(pos);
        }
        public static List<Positions> search(string PosName)
        {
            return pos_act.search(PosName);
        }
        public static bool checkName(string name)
        {
            return pos_act.checkName(name);
        }
    }
}
