using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaiSEP4.Repositories;
using DatabaseSEP4.Models;
using Microsoft.AspNetCore.Mvc;

namespace DaiSEP4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantController : ControllerBase
    {
        private IPlantRepositories _plantRepositories;

        public PlantController(IPlantRepositories plantRepositories)
        {
            this._plantRepositories = plantRepositories;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<IList<Plant>>> GetPlants()
        {
            try
            {
                IList<Plant> plants = await _plantRepositories.GetAllPlants();
                return Ok(plants);
            }
            catch (Exception e)
            {
                Console.Write(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<Plant>> GetPlant(int id)
        {
            try
            {
                Plant plant = await _plantRepositories.GetPlant(id);
                return Ok(plant);
            }
            catch (Exception e)
            {
                Console.Write(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Plant>> AddPlant([FromBody] Plant plant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Plant added = await _plantRepositories.CreatePlant(plant);
                return Created("added", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}