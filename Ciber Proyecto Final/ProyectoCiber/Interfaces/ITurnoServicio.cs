using System.Collections.Generic;
using ProyectoCiber.Models;

namespace ProyectoCiber.Interfaces
{
    public interface ITurnoServicio
    {
        IEnumerable<Turno> GetAll();
        Turno Add(Turno turno);
        Turno Update(Turno turno);
        bool Delete(int id);

    }
}