using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Category Name")]
        public String Name { get; set; }
    }
}
