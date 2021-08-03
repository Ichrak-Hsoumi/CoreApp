using CoreAppliction.Areas.Admin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppliction.Areas.Admin.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _iuserservice;
        public UserController(IUserService _iuserservice)
        {
            this._iuserservice = _iuserservice;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _iuserservice.getUsers();
            return Ok(users);
        }
    }
}
