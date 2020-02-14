using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //int packageHeight = 25;
            //int packageWidth = 10;
            //bool tooBig = (packageHeight > 25 && packageWidth > 25)
            //Console.WriteLine(tooBig);

            //int packageHeight = 25;
            //int packageWidth = 10;
            //bool tooBig = (packageHeight > 25 || packageWidth > 25)
            //Console.WriteLine(tooBig);

            //string firstName = “Jesse”;
            //string lastName = “Johnson”;
            //string socialSecurityNumber = “111 - 11 - 1111”
            //bool isAuthorized = (firstName == “Jesse” && lastName == “Johnson” && socialSecurityNumber == “111 - 11 - 1111”)
            //Console.WriteLine(isAuthorized);

            //int bankAccountBalance = 500;
            //bool isInARockBand = false;
            //string name == “Jesse”;
            //bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == “Jesse”);

            //bool result = (true && (true || false));

            //Console.WriteLine(true && false);
            ////Console.WriteLine( true && true);
            ////Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);
            //Console.ReadLine();

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);
            //Console.ReadLine();

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);
            //Console.ReadLine();


            Console.WriteLine("Whats your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);


            Console.WriteLine("Have you ever had a DUI? - True or False");
            string dui = Console.ReadLine();
            bool dui1 = Convert.ToBoolean(dui);
            bool no = false;
            bool yes = true; 

            Console.WriteLine("How Many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tickets1 = Convert.ToInt32(tickets);
            


            bool isAuthorized = (age1 > 15 && dui1 == false && tickets1 <= 3);
            Console.WriteLine(isAuthorized);












        }
    }
}
