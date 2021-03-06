﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1 from webapi B", "value2 from webapi B" };
        }

        [HttpGet]
        [Route("allProducts")]
        public string AllProducts()
        {
            return "返回所有产品信息";
        }

        [HttpGet]
        [Route("registerUser")]
        public string registerUser()
        {
            
            return "error";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        /// <summary>
        /// Service健康检查
        /// </summary>
        /// <returns></returns>
        [Route("health")]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}
