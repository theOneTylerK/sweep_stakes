using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestantDictionary;
        
        string name;
        

        public Sweepstakes(string name)
        {

            this.name = name;
            this.contestantDictionary = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestantDictionary.Count + 1;
            int TicketNumber = contestant.registrationNumber;
            contestant.firstName = UserInterface.GetUserStringInput("Please enter contestant's first name");
            contestant.lastName = UserInterface.GetUserStringInput("Please enter contestant's last name");
            contestant.emailAddress = UserInterface.GetUserStringInput("Please enter contestant's email address");
            contestantDictionary.Add(TicketNumber, contestant);

        }

        public Contestant PickWinner()
        {
            int WinningSpot = UserInterface.GetRandom(1, contestantDictionary.Count + 1);
            Console.WriteLine($"The Winner of {name} is {contestantDictionary[WinningSpot].firstName} {contestantDictionary[WinningSpot].lastName}");
            Console.ReadLine();
           Contestant WinningContestant = contestantDictionary[WinningSpot];

            return WinningContestant;
        }

        public void NotifyContestants()
        {
            Contestant Winner = PickWinner();
            for (int i = 1; i < contestantDictionary.Count; i++)
            {
                if (contestantDictionary[i].registrationNumber == Winner.registrationNumber)
                {
                    Console.WriteLine($"Congratulations {contestantDictionary[i].firstName} {contestantDictionary[i].lastName}\n You have won the {name} Sweepstakes!");
                }
                else
                {
                    Console.WriteLine($"{contestantDictionary[i].firstName} {contestantDictionary[i].lastName},\n Thank you for entering the {name} Sweepstakes. Unfortunately, someone else was chosen as the winner. Try again next time.");
                }
            }

        }

        public void PrintContestantInfo(Contestant contestant)
        {
          Console.WriteLine($"{contestant.firstName} \n {contestant.lastName} \n {contestant.emailAddress} \n {contestant.registrationNumber}");  
        }
    }
}
