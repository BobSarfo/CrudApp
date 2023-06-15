using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebService.DTOs;
using WebService.Models;

namespace WebService.Controllers
{
    [RoutePrefix("api/persons"), AllowAnonymous]
    public class PersonController : ApiController
    {

        [Route(), HttpGet, AllowAnonymous]
        public async Task<IHttpActionResult> GetAll()
        {
            CrudAppDb db = new  CrudAppDb();
            var ab = await db.Persons.ToListAsync();
            return null;
        }


        [Route("{id}"), HttpGet, AllowAnonymous]
        public async Task<IHttpActionResult> GetById(int id)
        {
            return null;
        }

        [Route(), HttpPost, AllowAnonymous]

        public async Task<IHttpActionResult> Post([FromBody] PersonDto personDto)
        {
            return null;
        }


        [Route("{id}"), HttpDelete, AllowAnonymous]
        public void Delete(int id)
        {
        }
    }
}
