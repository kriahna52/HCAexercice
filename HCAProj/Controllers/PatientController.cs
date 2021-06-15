using HCAProj.Models;
using HCAProj.Models.PatientContext;
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
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepo _context;
        public PatientController(IPatientRepo patients)
        {
            _context = patients;
        }

        // GET: api/<LabTestsController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _context.Get();
        }

        // GET api/<LabTestsController>/5
        [HttpGet("{id}")]
        public Patient Get(string id)
        {
            return _context.Get(id);
        }


        [HttpPost()]
        public LabTest Get(LabTestFilter filter)
        {
            return _context.Get(filter);
        }

        // POST api/<LabTestsController>
        [HttpPost]
        public void Post(Patient value)
        {
            _context.Add(value);
        }

        // PUT api/<LabTestsController>/5
        [HttpPut("{id}")]
        public void Put(Patient value)
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
