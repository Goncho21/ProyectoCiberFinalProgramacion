using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using ProyectoCiber.Data;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Models;



namespace ProyectoCiber.Servicio
{
    public class PCServicio : IPCServicio
    {
        private readonly TurnoDBContext _context;

        public PCServicio(TurnoDBContext context)
        {
            _context = context;
        }

        public IEnumerable<PC> GetAll()
        {
            return _context.PCs.ToList();
        }

        public PC Add(PC pc)
        {
            _context.PCs.Add(pc);
            _context.SaveChanges();
            return pc;
        }

        public PC? Update(int id, PC pcactualizado)
        {
            var pcexistente = _context.PCs.FirstOrDefault(p => p.Id == id);
            if (pcexistente == null)
                return null;

            pcexistente.Tipo = pcactualizado.Tipo;
            pcexistente.Gama = pcactualizado.Gama;

            _context.SaveChanges();
            return pcexistente;
        }

        public bool Delete(int id)
        {
            var pc= _context.PCs.FirstOrDefault(p => p.Id == id);
            if (pc == null)
                return false;

            _context.PCs.Remove(pc);
            _context.SaveChanges();
            return true;
        }

    }
}
