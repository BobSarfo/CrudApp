using CrudApp.DAL;
using CrudApp.DTOs;
using CrudApp.Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web.Http;

namespace CrudApp.Controllers
{
    [RoutePrefix("api/persons"), AllowAnonymous]
    public class PersonsController : ApiController
    {


        [Route("{searchString}"), HttpGet]
        public async Task<IHttpActionResult> GetAll(string searchString)
        {
            List<Person> people;
            if (searchString is null)
            {
                people = await PersonService.GetPersonsAsync();
            }
            else
            {
                people = await PersonService.SearchPersonAsync(searchString);
            }

            return Ok(people);
        }

        [Route(), HttpGet]
        public async Task<IHttpActionResult> Post([FromBody] PersonDto personDto)
        {

            if (personDto == null || personDto.FirstName == null) return BadRequest();

            Person person = new Person { Age = personDto.Age, FirstName = personDto.FirstName, LastName = personDto.LastName };

            bool result = await PersonService.AddPersonAsync(person);

            return Created("/", result);
        }


        [Route("{id}"), HttpDelete]

        public async Task<IHttpActionResult> Delete(int id)
        {
            bool succeeded = await PersonService.DeletePersonAsync(id);
            if (!succeeded) return NotFound();    

            return Ok();
        }
    }
}