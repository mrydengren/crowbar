﻿using System.Collections.Generic;
using System.Web.Http;

namespace Crowbar.Demo.Mvc.WebApi.Application
{
    public class CrowbarsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new[] { "Pry Bar", "Wrecking Bar", "Digging Bar" };
        }
    }
}