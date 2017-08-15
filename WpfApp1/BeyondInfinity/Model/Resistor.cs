using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondInfinity.Model
{
    class Resistor
    {
        public Resistor(double resistance)
        {
            if (resistance <= 0.0)
                throw new Exception("Resistance must be positive");
            _resistance = resistance;
            _current = 0.0;
            _voltageDrop = 0.0;
            _power = 0.0;
        }
        private double _resistance;
        public double Resistance
        {
            get { return _resistance; }
            set { _resistance = value; }
        }

        private double _current;
        public double Current
        {
            get { return _current; }
            set { _current = value; _voltageDrop = _resistance * _current; _power = _voltageDrop * _current; }
        }

        private double _voltageDrop;
        public double VoltageDrop
        {
            get { return _voltageDrop; }
            set { _voltageDrop = value; _current = _voltageDrop / _resistance; _power = _voltageDrop * _current; }
        }

        private double _power;
        public double Power
        {
            get { return _power; }
        }
    }
}
