using System.Collections.Generic;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    [RoutePrefix("Lib")]
    public class AccountController : ApiController
    {
        static List<string> Accounts = new List<string>() {
            "12345645","12340998","1234975656"
        };

        // GET: api/Users
        [HttpGet, Route("accounts/{accountNo:validAccount}")]

        // GET: api/Users/5
        public string AccountNumber(int accountNo)
        {
            return accountNo.ToString();
        }

        [HttpGet]
        [Route("Library")]
        // GET: api/Users/5
        public string AccountNumber()
        {
            return "Hello Prem!!!";
        }

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
