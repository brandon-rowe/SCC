using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Rowe_Chapter_10
{
    class Employee : ProductionWorker
    {
        private string _employeeName;
        private string _employeeNumber;

        public Employee(string name, string id)
            : base(shift, payRate)
        {
            _employeeName = name;
        }
    
        public string name
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public string id
        {
            get { return _employeeNumber;}
            set { _employeeNumber = value;}
        }
    }
}
