using CoreAppliction.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAppliction.Models;

namespace CoreAppliction.Areas.Admin.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _db;
        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ApplicationUser> getUsers()
        {
            return _db.Users;
        }
    }
}
