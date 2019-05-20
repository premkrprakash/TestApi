using System.Collections.Generic;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> Names = new List<string>() {
            "Prem Prakash","Vikas Kumar","Praveen Kumar","Prashant Kumar","Deepak Kumar"
        };
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return Names;
        }

        // GET: api/Values/5
        public string Get(int id)
        {
            return Names[id];
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
            Names.Add(value);
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
            Names[id] = value;
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
            Names.RemoveAt(id);
        }
    }
}
