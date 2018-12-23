using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Food_Entity
{
    public class Food_Type
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20,MinimumLength =5, ErrorMessage ="5 chars least")]
        public string nameType { get; set; }
    }
}
