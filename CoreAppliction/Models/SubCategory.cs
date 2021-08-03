using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}