using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CusOrders
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int numberDish { get; set; }
        public DateTime dateOrder { get; set; }
        public double totalcost { get; set; }
    }
}
