using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models
{
    public class LabTest
    {

        public string LabTestId { get; set; }

        public string Type { get; set; }

        public bool Result { get; set; }

        public DateTime TestTime { get; set; }

        public DateTime EnteredTime { get; set; }

        public long TechnicianId { get; set; }
    }
}
