using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ServiceHosting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly List<string> _List = Enumerable.Range(1, 10).Select(i => $"Value {i}").ToList();

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => _List;

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0) 
                return BadRequest();
            if (id >= _List.Count)
                return NotFound();
            return _List[id];
        }

        [HttpPost]
        public void Post(string value) => _List.Add(value);

        [HttpPut("{id}")]
        public ActionResult Put(int id, string value)
        {
            if (id < 0 || id >= _List.Count)
                return BadRequest();

            _List[id] = value;

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest();
            if (id >= _List.Count)
                return NotFound();
            _List.RemoveAt(id);
            return Ok();

        }
    }
}