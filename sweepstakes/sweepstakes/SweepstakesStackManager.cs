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

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {            
            Sweepstakes recoveredSweepstakes = sweepstakesStack.Pop();
            return recoveredSweepstakes;
        }

        public void getUsed()
        {
            Console.WriteLine("Onward to the Stack Manager");
        }
    }
    
}
