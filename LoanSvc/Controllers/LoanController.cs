using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using System.Xml.Linq;

namespace LoanSvc.Controllers
{
    public class LoanController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        [AllowAnonymous]
        //[Route("api/loan/uploadXML/{file}")] 
        // POST api/<controller>
        public async void Post(string file)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        [AllowAnonymous]
        [Route("api/loan/uploadXML/{file}")] 
        [HttpPost]
        public void uploadFile(HttpRequestMessage file)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(file.Content.ReadAsStreamAsync().Result);  
        }
    }
}