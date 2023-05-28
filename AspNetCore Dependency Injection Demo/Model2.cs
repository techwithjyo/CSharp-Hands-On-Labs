using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore_Dependency_Injection_Demo
{
    public class Model2
    {
        private readonly IMyDependency _myDependency;


        public Model2(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }
        public void OnGet()
        {
            _myDependency.WriteMessage("Model2.OnGet");
        }
    }
}
