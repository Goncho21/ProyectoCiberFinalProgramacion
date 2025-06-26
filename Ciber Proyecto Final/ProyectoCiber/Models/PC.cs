namespace ProyectoCiber.Models
{
    public class PC
    {
        public PC()
        {
        }
        public int Id { get; set; }


        public string Tipo { get; set; } // Consola o Pc

        public string Gama { get; set; }// Game baja, Media, Alta

        public int Duracion { get; set; } // tiempo de uso


        public PC(int id, string tipo, string gama, int duracion)
        {
            Id = id;
            Tipo = tipo;
            Gama = gama;
            Duracion = duracion;
        }
    }
}
