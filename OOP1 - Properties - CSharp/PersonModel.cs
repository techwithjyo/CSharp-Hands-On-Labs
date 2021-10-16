using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1___Properties___CSharp
{
    class PersonModel
    {
        public string FirstName { get; set; } // => Auto Property
        public string LastName { get; set; }
        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in valid number range..");
                }
            }
        }

        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);

                return output;
            }
            set { _ssn = value; }
        }

        private string _fullName;

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            private set
            {
                _fullName = value;
            }
        }


    }
}
