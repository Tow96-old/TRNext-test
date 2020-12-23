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

        #region Parameter encapsulators
        public Clothing Clothing { get { return this.clothing; } }
        #endregion

        #region Functions
        public void DressUp(int buttons) {
            this.clothing = new Coat(buttons);
        }
        #endregion
    }
}
