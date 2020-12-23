using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Stat
     * Numeric value to a specific attribute such as strengths
     */ 
    public class Stat
    {
        #region Properties
        private string name; // Name of the attribute;
        private int value;   // Value of the stat
        private int max = 5; // Max possible value hardcoded as 5;
        #endregion

        /** Constructor
         * <summary Creates a stat />
         * <param name="initialValue" value the Stat will begin as MAX=5 />
         * <param name="name" name of the attribute />
         */
        public Stat(string name, int initialValue)
        {
            this.name = name;
            this.value = initialValue > this.max ? this.max : initialValue;
        }

        #region Parameter encapsulators
        public string Name { get { return this.name; } }
        public int Value { get { return this.value; } }
        #endregion

        #region Functions
        public int RaiseStat()
        {
            // Increases the value of the stat, if somehow it exceeded the max, it is reset.
            this.value = this.value >= this.max ? this.max : this.value + 1;
            return this.value;
        }
        #endregion
    }
}
