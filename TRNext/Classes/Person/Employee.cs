using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    /** Employee
     * class that describes an employee
     */
    public class Employee: Person
    {
        #region Properties
        protected DateTime joined;
        protected int payroll;
        #endregion

        public Employee(String name, int age, int payroll) : base(name, age)
        {
            this.joined = DateTime.Now;
            this.payroll = payroll;
        }
        public Employee(Person input, int payroll) : base(input.Name, input.Age)
        {
            this.joined = DateTime.Now;
            this.payroll = payroll;
            this.strength = input.Strength;
            this.intelligence = input.Intelligence;
            this.charisma = input.Charisma;
            this.clothing = input.Clothing;
        }

        #region Parameter encapsulators
        public DateTime JoinedAt { get { return this.joined; } }
        public int Payroll { get { return this.payroll; } }
        #endregion
    }
}
