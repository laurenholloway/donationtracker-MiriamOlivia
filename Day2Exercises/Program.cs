using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            //Variable for cups required
            double cupsRequired = 7;
            //Variable for cups added
            double cupsAdded = 2;
            Console.WriteLine(cupsRequired - cupsAdded);
            
            //Console.ReadKey();

            double packageCost = 8;
            double totalCost = 40;
            Console.WriteLine(totalCost / packageCost);
            Console.ReadKey();
            

            double juliaMiles = 47;
            Console.WriteLine(juliaMiles - 30);
            Console.ReadKey();

            double saladAmount = 5.12;
            double currentFund = 27.10;
            Console.WriteLine(currentFund + saladAmount);
            Console.ReadKey();
            

            double amountTospend = 24;
            double numberOfpencils = 7;
            double currentAmount = 10;
            Console.WriteLine((amountTospend - currentAmount) / numberOfpencils);
            Console.ReadKey();
            

            double sumTotal = 72;
            double numberOfVariable = 3;
            Console.WriteLine((sumTotal / numberOfVariable) - 1);
            Console.ReadKey();
            

            double boxesLeft = 22;
            double boxesBought = 7;
            double amountLost = .5;
            Console.WriteLine((boxesLeft * amountLost) - boxesBought);
            Console.ReadKey();
            

            Console.WriteLine("What was your score?");
            double score = double.Parse(Console.ReadLine());
            Console.WriteLine("Your score was " + score);
            */


            // string addressOfDonor = 
            //string emailOfDonor = 
            //double fiscalYear =
            Console.WriteLine("What is your name?");
            string nameOfdonor = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string addressOfDonor = Console.ReadLine();
            Console.WriteLine("What is your email?");
            string emailOfdonor = Console.ReadLine();
            Console.WriteLine("What is the fiscal year?");
             double fiscalYear = double.Parse(Console.ReadLine());
            Console.WriteLine("How many of each denomination are being donated?");

            Console.WriteLine("One dollar bill:");
            double oneDollar = double.Parse(Console.ReadLine());
            double oneDollartotal = oneDollar * 1;

            Console.WriteLine("Five dollar bill:");
            double fiveDollar = double.Parse(Console.ReadLine());
            double fiveDollartotal = fiveDollar * 5;

            Console.WriteLine("Ten dollar bill:");
            double tenDollar = double.Parse(Console.ReadLine());
            double tenDollartotal = tenDollar * 10;

            Console.WriteLine("Twenty dollar bill:");
            double twentyDollar = double.Parse(Console.ReadLine());
            double twentyDollartotal = twentyDollar * 20;


            Console.WriteLine("Fifty dollar bill:");
            double fiftyDollar = double.Parse(Console.ReadLine());
            double fiftyDollartotal = fiftyDollar * 50;

            Console.WriteLine("Hundred dollar bill:");
            double hundredDollar = double.Parse(Console.ReadLine());
            double hundreDollartotal = hundredDollar * 100;

            Console.WriteLine("Quarters:");
            double quarters = double.Parse(Console.ReadLine());
            double quarterTotal = quarters * .25;

            Console.WriteLine("Your name is: " + nameOfdonor);
            Console.WriteLine("Your address is: " + addressOfDonor);
            Console.WriteLine("Your email is: " + emailOfdonor);
            Console.WriteLine("Your fiscal year is: " + fiscalYear);
            double donationAmount = oneDollartotal + fiveDollartotal + tenDollartotal + twentyDollartotal + fiftyDollartotal + hundreDollartotal + quarterTotal;
            Console.WriteLine("Your donation amount is: $" + donationAmount);
            Console.ReadKey();
            //Number of bill * bill value



        }



    }
}
