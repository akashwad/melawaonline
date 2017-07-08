using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;

namespace MelawaOnline.Controllers
{
    public class SearchController : ApiController
    {
        [Route("Search")]
        [HttpPost]
        public string SearchProfile([FromBody]SearchCriteria searchCriteria)
        {
            Search prof = new Search();
            UserInfoDOJO[] arruserInfo = prof.SearchProfile(searchCriteria);

            return "";
        }
    }
}
