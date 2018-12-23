using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Model.Food_Entity
{
    public class Food_Size
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20,MinimumLength =5,ErrorMessage ="5 chars least")]
        public string name { get; set; }
    }
}
