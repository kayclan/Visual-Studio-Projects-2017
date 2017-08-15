using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondInfinity.Model
{
    class Battery
    {
        private double _voltage;
        private double _current;

        public Battery(double Voltage)
        {
            _voltage = Voltage;
            _current = 0.0;
        }

        public double Voltage
        {
            get { return _voltage; }
            set { _voltage = value; }
        }

        public double Current
        {
            get { return _current; }
            set { _current = value; }
        }
    }
}
