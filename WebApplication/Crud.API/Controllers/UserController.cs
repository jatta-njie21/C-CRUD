using Crud.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Crud.BLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBLL _userBll;

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/GetUserByID/{ID}")]
        public HttpResponseMessage GetUserByID(ID)
        {
            var ret = _userBll.GetUser(ID);

            if (ret != null)
            {
                Request.HttpContext(Create)
            }
        }

        
    }
}
