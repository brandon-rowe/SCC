using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brandon_Rowe_Chapter_10
{
    abstract class ProductionWorker
    {
        private int _shift;
        private double _payRate;

        public ProductionWorker(int shift, double payRate)
        {
            _shift = shift;
            _payRate = payRate;
        }

        public int shift
        {
            get { return _shift; }
            set { _shift = value; }
        }

        public double payRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }
                
    }
}
