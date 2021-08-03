using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAppliction.Models;

namespace CoreAppliction.Areas.Admin.Services
{
    public interface IUserService
    {
        public IEnumerable<ApplicationUser> getUsers();
    }
}
