using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoCiber.Data;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Models;

namespace ProyectoCiber.Servicio
{
    public class TurnoServicio : ITurnoServicio
    {
        private readonly TurnoDBContext _context;

        public TurnoServicio(TurnoDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Turno> GetAll()
        {
            return _context.Turnos.ToList();
        }

        public Turno Add(Turno turno)
        {

            _context.Turnos.Add(turno);
            _context.SaveChanges();
            return turno;
        }

        public Turno Update(Turno turno)
        {
            if (turno == null)
                throw new ArgumentNullException(nameof(turno));

            var existing = _context.Turnos.FirstOrDefault(t => t.Id == turno.Id);
            if (existing != null)
            {
                existing.PC = turno.PC;
               
                existing.HorarioDeInicio = turno.HorarioDeInicio;

                _context.SaveChanges(); // Guarda cambios en la BD
                return existing;
            }

            // Si no existe, lanzar esto
            throw new InvalidOperationException($"El turno con ID {turno.Id} no se encontro");
        }

        public bool Delete(int id)
        {
            var turno = _context.Turnos.FirstOrDefault(t => t.Id == id);
            if (turno != null)
            {
                _context.Turnos.Remove(turno);
                _context.SaveChanges(); // Guarda en el SQL managment
            }
            return false;
        }
    }
}
