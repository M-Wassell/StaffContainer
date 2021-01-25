using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffContainer.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The product name must be inserted")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage ="A Price must be inserted")]
        public double Price { get; set; }
        public Remaining Remaining { get; set; }
        

    }
}
