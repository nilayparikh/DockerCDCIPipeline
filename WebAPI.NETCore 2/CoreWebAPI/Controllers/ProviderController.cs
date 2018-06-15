﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProviderController : Controller
    {
        // GET api/values/5
        // Logic Changed.
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id + " + 2 = " + (id + 2);
        }
    }
}
