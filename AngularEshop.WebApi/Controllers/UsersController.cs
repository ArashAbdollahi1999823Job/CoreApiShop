using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularEshop.WebApi.Controllers
{

    public class UsersController : SiteBaseController
    {


        #region ctor

        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region UserList
        [HttpGet("Users")]

        public async Task<ObjectResult> Users()
        {
            return  new ObjectResult(await _userService.GetAllUser());
   /*        var users = await _userService.GetAllUser();


        
           return Ok(new {id=users[0].Id});*/
        }

        #endregion


    }
}
