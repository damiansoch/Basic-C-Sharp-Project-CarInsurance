using System;

namespace Basic_C_Sharp_Project_CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance approval");
            Console.WriteLine("\n");

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);

            Console.WriteLine("Have you ever had a DUI violation? (Ansewer \"yes\" or \"no\") ");
            string voilatiuonsString = Console.ReadLine();
            bool voilations = voilatiuonsString == "yes" ? true : false;

            Console.WriteLine("How many speeding tickets have you had?");
            string ticketsString = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsString);

            Console.WriteLine("\n");


            Console.WriteLine("Applicants is over 15 years old. - " + (age > 15));
            Console.WriteLine("Applicants don't have any DUIs.. - " + (!voilations));
            Console.WriteLine("Applicants don't have more than 3 speeding tickets. - " + (tickets < 3));
            Console.WriteLine("\n");


            bool approved = (age > 15 && !voilations && tickets < 3);

            Console.WriteLine(approved ? "Application has been approved" : "Application denied!");

            Console.ReadLine();






        }
    }
}
