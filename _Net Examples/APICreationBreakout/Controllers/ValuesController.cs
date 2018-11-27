using APICreationBreakout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace APICreationBreakout.Controllers
{
    [RoutePrefix("api/chars")]
    public class ValuesController : ApiController
    {
        public List<NintendoCharacters> chars = new List<NintendoCharacters>() {
            new NintendoCharacters("Mario", "Super Mario Bros",99,true),
            new NintendoCharacters("Waluigi", "None", 0, false),
            new NintendoCharacters("Peach", "Super Mario Bros",20, true),
            new NintendoCharacters("Dr. Mario", "Dr. Mario",5, true)
        };
        // GET api/values
        [Route("")]
        public List<NintendoCharacters> Get()
        {
            return chars;
        }

        // GET api/values/5
        [Route("{id:int}")]
        public NintendoCharacters Get(int id)
        {
            return chars[id];
        }

        [Route("BestChar")]
        [HttpGet]
        public NintendoCharacters GetWaluigi()
        {
            return chars[1];
        }

        [Route("{name}")]
        [HttpGet]
        public List<NintendoCharacters> GetByName(string name)
        {
            var character = chars.Where(c => c.Name.Contains(name)).ToList();

            return character;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
