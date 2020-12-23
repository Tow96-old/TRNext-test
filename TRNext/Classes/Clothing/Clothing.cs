using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Main abstract clothing class
     */
    abstract public class Clothing
    {
        #region Properties
        protected string type;
        #endregion

        public Clothing(string type)
        {
            this.type = type;
        }

        #region Parameter encapsulator
        public string Type { get { return this.type; } }
        public virtual int Buttons { get { return 0; } }
        #endregion
    }
}
