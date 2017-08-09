using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeyondInfinity
{
    abstract class Problem
    {
        public abstract void createProblemGraphic(Grid problemGrid);
        public abstract void createAnswerGraphic(Grid answerGrid);
    }
}
