using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GO_BE.Factories;


namespace GO_BE.Controllers
{
    [EnableCors("*","*","*")]
    public class CompanyController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var response = CompanyFactory.GetCompany();
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

    }
}
