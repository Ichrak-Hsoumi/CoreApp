using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Models
{
    public class MenuByUser
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string MenuName { get; set; }
        public bool approved { get; set; }
    }
}
