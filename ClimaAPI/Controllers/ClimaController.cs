using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClimaAPI.Context;
using ClimaAPI.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClimaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        private readonly AppDbContext context;
        public ClimaController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<ClimaController>
        [HttpGet]
        public IQueryable<City> Get()
        {
            return context.city.Include( c => c.weather);
        }

        // GET api/<ClimaController>/5
        [HttpGet("{id}",Name ="GetCiudad")]
        public ActionResult Get(int id)
        {
            try
            {
                var ciudad = context.city.Include(c => c.weather).FirstOrDefault(g => g.id == id);
                return Ok(ciudad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClimaController>
        [HttpPost]
        public ActionResult Post([FromBody] City city)
        {
            try
            {
                context.city.Add(city);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClimaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] City city)
        {
            try
            {
                if (city.id == id)
                {
                    context.Entry(city).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCity", new { id = city.id }, city);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClimaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var ciudad = context.city.FirstOrDefault(g => g.id == id);
                if(ciudad != null)
                {
                    context.city.Remove(ciudad);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
