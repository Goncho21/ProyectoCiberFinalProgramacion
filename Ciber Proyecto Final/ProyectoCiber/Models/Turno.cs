namespace ProyectoCiber.Models
{
    public class Turno
    {
        public int Id { get; set; }

        public int PCId { get; set; }        // Clave 
        public PC? PC { get; set; }        

        public DateTime HorarioDeInicio { get; set; }

        public Turno() { }

        public Turno(int id, int pcId, DateTime inicio)
        {
            Id = id;
            PCId = pcId;
            HorarioDeInicio = inicio;
        }
    }
}
