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

        public Queue<Sweepstakes> InsertSweepstakes()
        {
           Sweepstakes newSweepstakes = new Sweepstakes(UserInterface.GetUserStringInput("Enter the name of the new Sweepstakes"));
           sweepstakesQueue.Enqueue(newSweepstakes);
           return sweepstakesQueue;
        }
    }
}
