using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes
{
    class Business
    {
        #region Properties
        private Manager manager;
        private List<Employee> engineers = new List<Employee>();
        private List<Employee> operators = new List<Employee>();

        // Default payrolls
        private int managerPayroll;
        private int engineerPayroll;
        private int operatorPayroll;

        // How many operators there will be
        private int maxEngineers;
        private int maxOperators;
        #endregion

        public Business(int maxEngineers = 10, int maxOperators = 20, int managerPayroll = 100, int engineerPayroll = 75, int operatorPayroll = 50)
        {
            this.maxEngineers = maxEngineers;
            this.maxOperators = maxOperators;
            this.managerPayroll = managerPayroll;
            this.engineerPayroll = engineerPayroll;
            this.operatorPayroll = operatorPayroll;
        }

        #region encapsulated Parameters
        public Manager Manager { get { return this.manager; } }
        public List<Employee> Engineers { get { return this.engineers; } }
        public List<Employee> Operators {  get { return this.operators; } }
        #endregion

        #region Functions
        public void addManager(Person manager) { 
            this.manager = new Manager(manager, managerPayroll); 
        }

        public Person hireEngineer(Person engineer)
        {
            if (this.engineers.Count >= maxEngineers) { return null; }
            this.engineers.Add(new Employee(engineer, engineerPayroll));
            return engineer;
        }

        public Person hireOperator(Person operat)
        {
            if (this.operators.Count >= maxOperators) { return null; }
            this.operators.Add(new Employee(operat, operatorPayroll));
            return operat;
        }

        #endregion

    }
}
