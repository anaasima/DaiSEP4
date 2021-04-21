using System;
using System.Threading.Tasks;
using DaiSEP4.Repositories;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Mvc;

namespace DaiSEP4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenerController : ControllerBase
    {
        private IGardenerRepositories _gardenerRepositories;

        public GardenerController(IGardenerRepositories gardenerRepositories)
        {
            this._gardenerRepositories = gardenerRepositories;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Gardener>> GetGardenerById([FromRoute] int id)
        {
            try
            {
                Gardener gardener = await _gardenerRepositories.GetGardener(id);
                return Ok(gardener);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateGardener([FromBody] Gardener gardener)
        {
            //complete this method
            return Ok();
        }
    }
}