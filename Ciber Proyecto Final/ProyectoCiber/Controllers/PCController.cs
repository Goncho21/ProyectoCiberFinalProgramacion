using Microsoft.AspNetCore.Mvc;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Models;

namespace ProyectoCiber.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class PCControllers : ControllerBase
        {
            private readonly IPCServicio _pcservicio;

            public PCControllers(IPCServicio pcservicio)
            {
                _pcservicio = pcservicio;
            }

            [HttpGet]

            public IEnumerable<PC> GetPC() => _pcservicio.GetAll();

            [HttpPost]

            public PC AddPC([FromBody] PC pc) => _pcservicio.Add(pc);

        [HttpPut("{id}")]
        public IActionResult UpdatePC(int id, [FromBody] PC pc)
        {
            // Validar que el objeto PC no sea nulo
            if (pc == null)
            {
                return BadRequest("El objeto PC no puede ser nulo.");
            }

            // Validar que el ID de la URL coincida con el ID del objeto
            if (id != pc.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del cuerpo.");
            }

            try
            {
                var updated = _pcservicio.Update(id, pc);
                if (updated == null)
                {
                    return NotFound($"No se encontró una PC con ID {id}.");
                }
                return Ok(updated);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest($"Argumento nulo: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la PC: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePC(int id)
        {
            var deleted = _pcservicio.Delete(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
    }

