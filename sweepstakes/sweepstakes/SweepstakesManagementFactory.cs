using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepstakesManagementFactory
    {
        string userInput;
        SweepstakesStackManager stackManager = new SweepstakesStackManager();
        SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
        public SweepstakesManagementFactory()
        {
            
        }
        
        public void ChooseManagementStyle()
        {
            userInput = UserInterface.GetUserStringInput("To create a sweepstakes using a Stack enter '1' \n To create a sweepstakes using a Queue enter '2'");
            switch (userInput)
            {
                case "1":
                case "one":
                    stackManager.GetSweepstakes();
                    break;
                case "2":
                case "two":
                    queueManager.GetSweepstakes();
                    break;
                default:
                    ChooseManagementStyle();
                    break;
            }
        }

    }
}
