using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models
{
    public class Patient
    {

        public string PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public IEnumerable<LabTest> Tests { get; set; }


    }
}
