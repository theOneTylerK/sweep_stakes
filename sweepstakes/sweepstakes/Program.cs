using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            //contestant.firstName = UserInterface.GetUserStringInput($"Please Enter Your First Name");
            contestant.registrationNumber = UserInterface.GetUserIntInput("Please enter your registration number");
        }
    }
}
