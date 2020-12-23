using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Person
     * Class to be used by everyone
     */ 
    public class Person
    {
        #region Properties
        protected int age;
        protected string name;
        protected Stat strength;
        protected Stat intelligence;
        protected Stat charisma;
        protected Clothing clothing = new Coat(-1);
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

            // Assigns random stats to the person
            var rand = new Random();
            this.strength = new Stat("Strength", rand.Next(5));
            this.intelligence = new Stat("Intelligence", rand.Next(5));
            this.charisma = new Stat("Charisma", rand.Next(5));

        }

        #region Parameter encapsulators
        // Name and age can only get as they are intrinsic to the person
        public string Name { get { return this.name; } }
        public int Age { get { return this.age; } }
        public Stat Strength { get { return this.strength; } }
        public Stat Intelligence {  get { return this.intelligence; } }
        public Stat Charisma {  get { return this.charisma; } }

        public Clothing Clothing {  get { return this.clothing; } }
        #endregion

        #region Functions
        public void DressUp(int buttons)
        {
            this.clothing = new Coat(buttons);
        }
        #endregion

    }
}
