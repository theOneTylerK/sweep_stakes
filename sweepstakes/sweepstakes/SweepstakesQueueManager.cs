using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesQueueManager: ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        public SweepstakesQueueManager()
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
            
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
           sweepstakesQueue.Enqueue(sweepstakes);
        }

        public void getUsed()
        {
            Console.WriteLine("Onward to the Queue manager");
        }
    }
}
