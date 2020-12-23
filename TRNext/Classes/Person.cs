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
        private int age;
        private int height;
        private string name;
        #endregion

        /** Constructor
         * <summary Creates the class />
         * <param name="age" age of the person />
         * <param name="height" height of the person in cm />
         * <param name="name" Name of the person />
         */
        public Person(String name, int age = -1, int height = -1)
        {
            this.age = age;
            this.height = height;
            this.name = name;
        }

        #region Parameter encapsulators
        public string Name { get { return this.name; } }
        #endregion

        #region Functions
        #endregion

    }
}
