using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Manager
    * Class that describes a manager,
    * it has the ability to get dressed (choose the amount of buttons on his coat)
    */
    class Manager : Employee
    {
        #region Properties
        #endregion

        /** Constructor
         * <summary Creates the class />
         */
        public Manager(String name, int age, int payroll): base(name, age, payroll)
        {
        }
        public Manager(Person input, int payroll):base(input.Name, input.Age, payroll) {
            this.strength = input.Strength;
            this.intelligence = input.Intelligence;
            this.charisma = input.Charisma;
            this.clothing = input.Clothing;
        }

        #region Parameter encapsulators
        #endregion

        #region Functions

        #endregion
    }
}
