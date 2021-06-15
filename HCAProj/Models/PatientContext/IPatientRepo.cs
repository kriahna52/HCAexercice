using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models.PatientContext
{
    public interface IPatientRepo
    {
        void Add(Patient patient);
        IEnumerable<Patient> Get();

        IEnumerable<Patient> Get(LabTestFilter filter);
        Patient Get(string id);
        Patient Delete(string id);
        void Update(Patient patient);
    }
}
