using CrudApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudApp.DAL
{
    public interface IPersonService
    {
        Task<bool> AddPersonAsync(Person person);
        Task<List<Person>> GetPersonsAsync();
        Task<List<Person>> SearchPersonAsync(string searchString);
        Task<bool> DeletePersonAsync(int id);
    }
}