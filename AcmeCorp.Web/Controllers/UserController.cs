using System.Collections.Generic;
using System.Threading.Tasks;
using AcmeCorp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCorp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            await Task.Run(() => { });
            return new List<User>
            {
                new User()
                {
                    Name = "Andrew",
                    UserId = System.Guid.NewGuid().ToString()
                }
            };
        }
    }
}