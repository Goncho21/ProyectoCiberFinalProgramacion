using ProyectoCiber.Models;
namespace ProyectoCiber.Interfaces
{
    public interface IPCServicio
    {
        IEnumerable<PC> GetAll();

        PC Add(PC pc);

        PC? Update(int id, PC pcactualizado);
        bool Delete(int id);
    }
}
