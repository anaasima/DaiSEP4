using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DaiSEP4.Repositories;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenController : ControllerBase
    {
        private IGardenRepositories _gardenRepositories;

        public GardenController(IGardenRepositories gardenRepositories)
        {
            this._gardenRepositories = gardenRepositories;
        }
        [HttpPost]
        public async Task<ActionResult> AddGarden([FromBody] DimGarden garden)
        {
            Console.WriteLine("Controller add garden called");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _gardenRepositories.CreateGarden(garden);
                return Created($"/{garden.Garden_ID}", garden);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<DimGarden>> GetGardenById([FromRoute] int id)
        {
            try
            {
                DimGarden garden = await _gardenRepositories.GetGardenById(id);
                return Ok(garden);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        /*[HttpGet]
        public async Task<ActionResult<IList<DimGarden>>> GetAllGardens()
        {
            try
            {
                using (SEP4DBContext context = new SEP4DBContext())
                {
                    Console.WriteLine("API Controller get families called");
                    List<DimGarden> gardens = await context.DimGarden.ToListAsync();
                    Console.WriteLine("Gardens" + gardens);
                    // context.DimGarden.Add(new DimGarden
                    // {
                    //     City = "Horsens",
                    //     LandArea = 12.5,
                    //     Name = "Me",
                    //     Number = 23,
                    //     Street = "Main"
                    // });
                    // context.SaveChangesAsync();
                    return Ok(gardens);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }  */
    }
}