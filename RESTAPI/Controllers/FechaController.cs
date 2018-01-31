using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPI.Controllers
{
    [Route("api/[controller]")]
    public class FechaController : Controller
    {
        // GET api/fecha
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { System.DateTime.Now.ToLongDateString(), DateTime.Now.TimeOfDay.ToString()};
        }

        // GET api/fecha/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            if(id=="dia")
            {
                return DateTime.Now.Day.ToString();
            }
            else if (id == "mes")
            {
                return DateTime.Now.Month.ToString();
            }
            else if (id == "hora")
            {
                return DateTime.Now.TimeOfDay.ToString();
            }
            else
            {
                return "Error...";
            }
           
        }

        //// POST api/fecha
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/fecha/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/fecha/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
