using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    public class SweepstakesManagementFactory 
    {
        public ISweepstakesManager ChooseManagementStyle()
        {
            string userInput = UserInterface.GetUserStringInput("To create a sweepstakes using a Stack enter '1' \n To create a sweepstakes using a Queue enter '2'");
            switch (userInput)
            {
                case "1":
                    return new SweepstakesStackManager();
                case "2":
                    return new SweepstakesQueueManager(); ;
                default:
                    return ChooseManagementStyle();
            }
        }

    }
}
