using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCiber.Models;
using ProyectoCiber.Interfaces;
using ProyectoCiber.Servicio;
using System.Net.Http.Json;


namespace ProyectoCiber.Desktop
{
    public class CiberHttpCliente
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseurl = "https://localhost:7180/api/pc";

        public CiberHttpCliente()
        {
            _httpClient = new HttpClient();
        }

        // GET Obtener todos los PC 

        public async Task<IEnumerable<PC>> GetAllAsync()
        {
            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<PC>>(_baseurl);
            return alumnos ?? new List<PC>();

        }

        // GET  Obtener un solo PC por ID
        public async Task<PC> GetByIdAsync(int id)
        {
            var pc = await _httpClient.GetFromJsonAsync<PC>($"{_baseurl}/{id}");
            if (pc == null)
                throw new Exception($"No se encontró el la PC con ID {id}.");
            return pc;

        }
        // POST Agregar un nuevo PC
        public async Task<PC> AddAsync(PC pc)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseurl, pc);
            response.EnsureSuccessStatusCode();
            var nuevoAlumno = await response.Content.ReadFromJsonAsync<PC>();

            if (nuevoAlumno == null)
                throw new Exception("Error al crear PC.");

            return nuevoAlumno;

        }

        // PUT Actualizar una PC
        public async Task<PC> UpdateAsync(int id, PC pc)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseurl}/{id}", pc);
            response.EnsureSuccessStatusCode();
            var actualizado = await response.Content.ReadFromJsonAsync<PC>();

            if (actualizado == null)
                throw new Exception($"Error al actualizar PC con ID {id}.");

            return actualizado;

        }

        // DELETE Eliminar unA PC
        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseurl}/{id}");
            return response.IsSuccessStatusCode;
        }


    }
}
