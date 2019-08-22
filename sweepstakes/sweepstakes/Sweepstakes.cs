using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MailKit.Net.Smtp;
//using MailKit;
//using MimeKit;
using System.Net;
using System.Net.Mail;
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
            for (int i = 1; i < contestantDictionary.Count + 1; i++)
            {
                if (contestantDictionary[i].registrationNumber == Winner.registrationNumber)
                {

                    sendWinnerEmail(Winner.firstName, Winner.lastName, Winner.emailAddress);
                    Console.WriteLine($"Congrats {Winner.firstName} {Winner.lastName}. You Won!");
                    Console.ReadLine();
                    
                }
                else
                {

                    sendLoserEmail(contestantDictionary[i].firstName, contestantDictionary[i].lastName, contestantDictionary[i].emailAddress);
                    Console.WriteLine($"Sorry {contestantDictionary[i].firstName} {contestantDictionary[i].lastName}. You didn't win.");
                    Console.ReadLine();
                }
            }

        }

        public void sendWinnerEmail(string firstName, string lastName, string emailAddress)
        {
            var fromAddress = new MailAddress("test.sweepstakesannouncer@gmail.com", "Sweepstakes Announcer");
            var toAddress = new MailAddress($"{emailAddress}", $"{firstName} {lastName}");
            string password = "TacoCat24$$";
            string subject = $"{name} Sweepstakes Update";
            string body = "";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("test.sweepstakesannouncer", password)
            };

            using (var message = new MailMessage(fromAddress, toAddress))
            {
                string Subject = subject;
                body = $"Congratulations {firstName}! You won the {name} sweepstakes!\n --Sweepstakes Announcer";
            }
            {
                smtp.Send(fromAddress.Address, toAddress.Address, subject, body);
            }
        }


        public void sendLoserEmail(string firstName, string lastName, string emailAddress)
        {
            {
                var fromAddress = new MailAddress("test.sweepstakesannouncer@gmail.com", "Sweepstakes Announcer");
                var toAddress = new MailAddress($"{emailAddress}", $"{firstName} {lastName}");
                string password = "TacoCat24$$";
                string subject = $"{name} Sweepstakes Update";
                string body = "";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("test.sweepstakesannouncer", password)
                };

                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    string Subject = subject;
                    body = $"Hello {firstName}! We regret to inform you that you did not win the {name} sweepstakes! Please try again. \n --Sweepstakes Announcer";
                }
                {
                    smtp.Send(fromAddress.Address, toAddress.Address, subject, body);
                }
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
          Console.WriteLine($"{contestant.firstName} \n {contestant.lastName} \n {contestant.emailAddress} \n {contestant.registrationNumber}");  
        }


    }
}
