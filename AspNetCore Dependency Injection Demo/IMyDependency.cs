using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore_Dependency_Injection_Demo
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
    }
}
