using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCAProj.Models
{
    public interface ILabTestRepo
    {
        void Add(LabTest test);
        IEnumerable<LabTest> Get();
      
        LabTest Get(string id);
        LabTest Delete(string id);
        void Update(LabTest test);
    }
}
