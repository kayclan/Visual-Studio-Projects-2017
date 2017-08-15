using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondInfinity.Model
{
    class OneBatteryOneResistorCircuit : Circuit
    {
        Battery _battery;
        Resistor _resistor;

        public OneBatteryOneResistorCircuit()
        {
            _resistor = new Resistor(getRandResistance());
            _resistor.Current = getRandCurrent();
            _battery = new Battery(_resistor.VoltageDrop);
        }

        public Battery Battery { get; }
        public Resistor Resistor { get; }
    }
}
