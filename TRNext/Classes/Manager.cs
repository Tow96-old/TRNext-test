using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    class Manager: Person
    {
        /** Constructor
         * <summary Creates the class />
         */
        public Manager(String name, int age = -1): base(name, age)
        {
        }
    }
}
