using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ClimaAPI.Context;
using ClimaAPI.Models;
using Microsoft.EntityFrameworkCore;


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
        // Listar
        [HttpGet]
        public IQueryable<City> Get()
        {
            return context.city.Include(c => c.weather).Include(c => c.coord);
        }

        // Obtener por ID
        [HttpGet("{id}",Name ="GetCiudad")]
        public ActionResult Get(int id)
        {
            try
            {
                var ciudad = context.city.Include(c => c.weather).Include(c => c.coord).FirstOrDefault(g => g.id == id);
                return Ok(ciudad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Crear
        [HttpPost]
        public ActionResult Post([FromBody] City city)
        {
            try
            {
                context.Add(city);

                foreach (Weather oWeather in city.weather)
                {
                    var clima = context.weather.Find(oWeather.id);
                    if (clima != null)
                        context.Entry(clima).State = EntityState.Unchanged;
                }

                context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Actualizar
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

        //  Eliminar
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
