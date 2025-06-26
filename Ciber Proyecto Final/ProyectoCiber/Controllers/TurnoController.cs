using Microsoft.AspNetCore.Mvc;
using ProyectoCiber.Models;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Servicio;

namespace ProyectoCiber.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
        public class TurnoController : ControllerBase
        {
            private readonly ITurnoServicio _turnoservicio;

            public TurnoController(ITurnoServicio turnoservicio)
            {
                _turnoservicio = turnoservicio;
            }

            [HttpGet]

            public IEnumerable<Turno> GetTurnos() => _turnoservicio.GetAll();

            [HttpPost]

            public Turno AddTurno([FromBody] Turno turno) => _turnoservicio.Add(turno);

            [HttpDelete("{id}")]
            public IActionResult DeleteTurno(int id)
            {
                var deleted = _turnoservicio.Delete(id);

                if (deleted)
                    return NoContent();

                return NotFound();
            }


        [HttpPut("{id}")]
        public IActionResult UpdatePC(int id, [FromBody] Turno turno)
        {
            if (id != turno.Id)
            {
                return BadRequest("El ID de la URL no coincide con el ID del cuerpo.");
            }

            var updated = _turnoservicio.Update(turno);
            if (updated == null)
            {
                return NotFound();
            }

            return Ok(updated);
        }
    }
    }
