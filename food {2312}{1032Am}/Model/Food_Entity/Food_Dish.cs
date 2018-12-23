using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Food_Entity
{
    public class Food_Dish
    {
        [Key]
        public int Id { get; set; }
        [MinLength(5)]
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Food_Type Food_Type { get; set; }

        public int SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Food_Size Food_Size { get; set; }
        
        public string imaGeURL { get; set; }
        public bool isLock { get; set; }
        public int stock { get; set; }
    }
}
