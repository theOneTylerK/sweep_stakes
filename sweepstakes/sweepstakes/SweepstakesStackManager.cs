using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesStackManager: ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();

        public SweepstakesStackManager()
        {

        }

        public void InsertSweepstakes(Sweepstakes newSweepstakes)
        {
            sweepstakesStack.Push(newSweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {            
            Sweepstakes recoveredSweepstakes = sweepstakesStack.Pop();
            return recoveredSweepstakes;
        }
    }
    
}
