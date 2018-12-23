using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderHistorys
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int numberDish { get; set; }
        public DateTime dateOrder { get; set; }
    }
}
