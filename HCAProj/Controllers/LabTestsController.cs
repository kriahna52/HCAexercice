using HCAProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HCAProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabTestsController : ControllerBase
    {
        private readonly ILabTestRepo _context;
        public LabTestsController(ILabTestRepo tests)
        {
            _context = tests;
        }
        
        // GET: api/<LabTestsController>
        [HttpGet]
        public IEnumerable<LabTest> Get()
        {
            return _context.Get();
        }

        // GET api/<LabTestsController>/5
        [HttpGet("{id}")]
        public LabTest Get(string id)
        {
            return _context.Get(id);
        }


    

        // POST api/<LabTestsController>
        [HttpPost]
        public void Post(LabTest value)
        {
            _context.Add(value);
        }

        // PUT api/<LabTestsController>/5
        [HttpPut("{id}")]
        public void Put(LabTest value)
        {
            _context.Update(value);
        }

        // DELETE api/<LabTestsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _context.Delete(id);
        }
    }
}
