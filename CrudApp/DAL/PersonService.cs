using CrudApp.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.DAL
{
    public class PersonService
    {
        public static async Task<bool> AddPersonAsync(Person person)
        {
            if (person.FirstName != null && person.LastName != null)
            {
                CrudAppDbContext db = new CrudAppDbContext();
                db.Persons.Add(person);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public static async Task<List<Person>> GetPersonsAsync()
        {

            CrudAppDbContext db = new CrudAppDbContext();
            return await db.Persons.ToListAsync();
        }

        public static async Task<List<Person>> SearchPersonAsync(string searchString)
        {
            CrudAppDbContext db = new CrudAppDbContext();
            return await db.Persons.Where(p => p.FirstName.ToLower().Trim().Equals(searchString.ToLower().Trim()) || p.LastName.Trim().ToLower().Equals(searchString.ToLower().Trim())).ToListAsync();
        }

        public static async Task<bool> DeletePersonAsync(int id)
        {
            CrudAppDbContext db = new CrudAppDbContext();

            Person person = await db.Persons.SingleOrDefaultAsync(p => p.Id == id);

            if (person != null)
            {
                db.Persons.Remove(person);
                await db.SaveChangesAsync();
                return true;
            }
            else return false;
        }
    }
}