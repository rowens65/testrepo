using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebRole1.Models;

namespace WebRole1.Controllers
{
    public class UsersController : ApiController
    {
        private User[] users = new User[]
        {
        new User { id = 1, name = "Roy Owens", email = "rowens65@gmail.com", phone = "01111111", role = 1},
        new User { id = 2, name = "Mukul Panwar", email = "mukul.panwar@gmail.com", phone = "01111111", role = 2},
        new User { id = 5, name = "Santosh Gurijala", email = "santosh.gurijala@gmail.com", phone = "01111111", role = 3}
        };

        // GET: api/Users

        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/Users/5

        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
