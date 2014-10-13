using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestApi.Controllers
{
    [RoutePrefix("customers")]
    public class CustomerController : ApiController
    {
        [Route("putcustomer")]
        public async Task<HttpResponseMessage> Put(List<Customer> customers)
        {
            //var orders = customers[0].Orders;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
