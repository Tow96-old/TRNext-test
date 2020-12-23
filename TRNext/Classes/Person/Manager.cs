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
    class Manager : Person
    {
        #region Properties
        private int coat_buttons;
        protected Clothing clothing = new Coat(-1);
        #endregion

        /** Constructor
         * <summary Creates the class />
         */
        public Manager(String name, int age = -1): base(name, age)
        {
            this.coat_buttons = 0; // The manager begins without a coat
        }

        #region Parameter encapsulators
        public int CoatButtons { 
            get { return this.coat_buttons; } 
            set { this.coat_buttons = value; }
        }
        public Clothing Clothing { get { return this.clothing; } }
        #endregion

        #region Functions
        public void DressUp(int buttons) {
            this.clothing = new Coat(buttons);
        }
        #endregion
    }
}
