using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudApp.DTOs
{
    public class Response<T>
    {
        public T data { get; set; }

    }
}