using ContactsAppV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactsAppV2.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return new Contact[]{
                new Contact { Id = 1, EmailAddress = "briar@contoso.com", Name = "Brian Redmond"},
                new Contact { Id = 2, EmailAddress = "johny@contoso.com", Name = "John Yokim"},
                new Contact { Id = 3, EmailAddress = "hammer@contoso.com", Name = "Todd Hammer"}
            };
        }
    }

}
