using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models

{
    public class LabTestRepo:ILabTestRepo
    {
        private static ConcurrentDictionary<string, LabTest> _tests =
              new ConcurrentDictionary<string, LabTest>();

        public LabTestRepo()
        {
         
        }

        public IEnumerable<LabTest> Get()
        {
            return _tests.Values;
        }

     
        public void Add(LabTest test)
        {
            test.LabTestId = Guid.NewGuid().ToString();
            _tests[test.LabTestId] = test;
        }

        public LabTest Get(string LabTestId)
        {
            LabTest test;
            _tests.TryGetValue(LabTestId, out test);
            return test;
        }

        public LabTest Delete(string LabTestId)
        {
            LabTest test;
            _tests.TryGetValue(LabTestId, out test);
            _tests.TryRemove(LabTestId, out test);
            return test;
        }

        public void Update(LabTest test)
        {
            _tests[test.LabTestId] = test;
        }

       
    }
}
