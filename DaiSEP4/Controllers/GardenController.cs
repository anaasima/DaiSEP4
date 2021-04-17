using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaiSEP4.DataAccess;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DaiSEP4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddGarden([FromBody] DimGarden garden)
        {
            Console.WriteLine("Controller add garden called");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                using (SEP4DBContext ctx = new SEP4DBContext())
                {
                    await ctx.DimGarden.AddAsync(new DimGarden
                    {
                        City = garden.City,
                        LandArea = garden.LandArea,
                        Name = garden.Name,
                        Street = garden.Street,
                        Number = garden.Number
                    });
                    await ctx.SaveChangesAsync();
                    return Created($"/{garden.Garden_ID}", garden);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        [HttpGet]
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
        }
    }
}