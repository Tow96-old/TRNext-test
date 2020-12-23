using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNext.Classes.Business
{
    class Business
    {
        #region Properties
        private Manager manager;
        private List<Employee> engineers = new List<Employee>();
        private List<Employee> operators = new List<Employee>();

        // How many operators there will be
        private int maxEngineers;
        private int maxOperators;
        #endregion

        public Business(int maxEngineers = 10, int maxOperators = 20)
        {
            this.maxEngineers = maxEngineers;
            this.maxOperators = maxOperators;
        }

        #region encapsulated Parameters
        public Manager Manager { get { return this.manager; } }
        public List<Employee> Engineers { get { return this.engineers; } }
        public List<Employee> Operators {  get { return this.operators; } }
        #endregion

        #region Functions
        public void addManager(Manager manager) { this.manager = manager; }

        public Employee hireEngineer(Employee engineer)
        {
            if (this.engineers.Count >= maxEngineers) { return null; }
            this.engineers.Add(engineer);
            return engineer;
        }

        public Employee hireOperator(Employee operat)
        {
            if (this.operators.Count >= maxOperators) { return null; }
            this.operators.Add(operat);
            return operat;
        }

        #endregion

    }
}
