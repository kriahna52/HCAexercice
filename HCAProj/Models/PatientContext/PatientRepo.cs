using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models.PatientContext
{
    public class PatientRepo : IPatientRepo
    {
        private static ConcurrentDictionary<string, Patient> _patients =
             new ConcurrentDictionary<string, Patient>();


        public IEnumerable<Patient> Get()
        {
            return _patients.Values;
        }

        public IEnumerable<Patient> Get(LabTestFilter filter)
        {
            return _patients.Values.Where(x => x.Tests.Where(y => y.TestTime <= filter.ToDate && y.TestTime >= filter.FromDate).Count() > 0);
        }     

        public Patient Get(string PatientId)
        {
            Patient patient;
            _patients.TryGetValue(PatientId, out patient);
            return patient;
        }

        public void Add(Patient patient)
        {
            patient.PatientId = Guid.NewGuid().ToString();
            _patients[patient.PatientId] = patient;
        }
        public Patient Delete(string PatientId)
        {
            Patient patient;
            _patients.TryGetValue(PatientId, out patient);
            _patients.TryRemove(PatientId, out patient);
            return patient;
        }

        public void Update(Patient patient)
        {
            _patients[patient.PatientId] = patient;
        }
    }
}
