using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore_Dependency_Injection_Demo
{
    public class Model1
    {
        private readonly Mydependency _dependency = new Mydependency();

        public void OnGet()
        {
            _dependency.WriteMessage("Model1.OnGet()");
        }

        public void TestMethod()
        {
            _dependency.WriteMessage("From Test Method!");
        }
    }
}
