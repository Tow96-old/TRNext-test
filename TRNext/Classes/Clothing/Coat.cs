using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Coat
     * Piece of clothing
     */
    class Coat : Clothing
    {
        #region Properties
        private int buttons;
        #endregion

        /** Constructor
        * <summary Creates the class />
        * <param name="buttons" Number of buttons in the coat />
        */
        public Coat(int buttons):base("Coat")
        {
            this.buttons = buttons;
        }

        #region Parameter encapsulator
        public override int Buttons{ get { return this.buttons; } }
        #endregion
    }
}
