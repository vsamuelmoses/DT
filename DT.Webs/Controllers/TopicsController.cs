using System.Collections.Generic;
using System.Web.Http;
using DT.Model;

namespace DT.Webs.Controllers
{
    public class TopicsController : ApiControllerBase
    {
        // GET: api/Topics
        public IEnumerable<Topic> Get()
        {
            //return new string[] { "value1", "value2" };
            return Uow.TopicRepository.GetAll();
        }

        // GET: api/Topics/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Topics
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Topics/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Topics/5
        public void Delete(int id)
        {
        }

    }
}
