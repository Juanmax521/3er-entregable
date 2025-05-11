using _3er_entregable.DAL.Entities;

namespace _3er_entregable.Domain.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountriesAsync(); // Obtiene todos los países, esta es una de las tantas firmas de método

        Task<Country> CreateCountryAsync(Country country); // Crea un nuevo país

        Task<Country> GetCountryById(Guid id); // Obtiene un país por su ID

        Task<Country> EditCountryAsync(Country country); // Actualiza un país existente

        Task<Country> DeleteCountryAsunc(Guid id); // Elimina un país existente

    }
}

