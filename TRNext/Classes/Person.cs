using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Person
     * Class to be used by everyone
     * TODO: Make it abstract when the child subclasses are created
     */ 
    public class Person
    {
        #region Properties
        protected int age;
        protected string name;
        #endregion

        /** Constructor
         * <summary Creates the class />
         * <param name="age" age of the person />
         * <param name="name" Name of the person />
         */
        public Person(String name, int age = -1)
        {
            this.age = age;
            this.name = name;
        }

        #region Parameter encapsulators
        // Name and age can only get as they are intrinsic to the person
        public string Name { get { return this.name; } }
        public int Age { get { return this.age; } }
        #endregion

        #region Functions
        #endregion

    }
}
