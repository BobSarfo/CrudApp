using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudApp.DTOs
{
    public class GetPersonsResponse : Response<List<Person>>
    {
    }
}