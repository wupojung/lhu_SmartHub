using Microsoft.AspNetCore.Mvc;
using SmartHub.Models;

namespace SmartHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PzemController : ControllerBase
    {


        public void Get()
        {
            
        }
        
        [HttpPost]
        public PzemEntiy Post([FromBody] PzemEntiy entiy)
        {
            Console.WriteLine(entiy.ToString());
         return entiy;

        }
        
    }
}
