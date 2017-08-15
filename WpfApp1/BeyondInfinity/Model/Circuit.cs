using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyondInfinity.Model
{
    class Circuit
    {
        Random _rand;

        public Circuit()
        {
            _rand = new System.Random();
        }

        protected double getRandVoltage()
        {
            return (_rand.Next(1, 20));
        }

        protected double getRandCurrent()
        {
            return (_rand.Next(1, 20));
        }

        protected double getRandResistance()
        {
            return (_rand.Next(1, 20));
        }
    }
}
