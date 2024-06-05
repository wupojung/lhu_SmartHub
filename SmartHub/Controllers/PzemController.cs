using Microsoft.AspNetCore.Mvc;
using SmartHub.Models;
using SmartHub.Services;

namespace SmartHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PzemController : ControllerBase
    {
        public IPzemService _pzemService;

        public PzemController(IPzemService pzemService)
        {
            _pzemService = pzemService;
        }

        [HttpGet("Top/{count?}")]
        public async Task<List<PzemEntiy>>  Top(int count = 10)
        {
            return  await _pzemService.ListAsync(count);
        }

        [HttpPost]
        public async Task<PzemEntiy> Post([FromBody] PzemEntiy entiy)
        {
            var result = await _pzemService.CreateAsync(entiy);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }

            return result;
        }
        
        
        
        
    }
}