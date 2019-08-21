using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager managementChoice;
        int numberOfSweepstakes;

        public MarketingFirm(ISweepstakesManager managementChoice)
        {
            this.managementChoice = managementChoice;
            numberOfSweepstakes = UserInterface.GetUserIntInput("How many Sweepstakes would you like to run?");
        }

        
        public void CreateSweepstakes()
        {
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                string name = UserInterface.GetUserStringInput("Please enter the name of the new Sweepstakes");
                Sweepstakes sweepstakes = new Sweepstakes(name);
                int numberOfContestants = UserInterface.GetUserIntInput("Please enter the amount of contestants you would like to add");

                for (int j = 0; j < numberOfContestants; j++)
                {
                    Contestant contestant = new Contestant();
                    sweepstakes.RegisterContestant(contestant);
                }

                managementChoice.InsertSweepstakes(sweepstakes);
            }
        }

        public void FinishSweepstakes()
        {

            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = managementChoice.GetSweepstakes();
                sweepstakes.NotifyContestants();
            }

        }

    }
}
