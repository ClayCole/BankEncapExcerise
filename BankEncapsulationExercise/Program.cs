using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello Bank of Cole User, Let's deposit some of your money to make me richer :)");
            Console.WriteLine("How much are you depositing today? :");
            var amount = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount(amount);

            // Use switch statement to give user options of 

            Console.WriteLine("Thank you user, Would you like to see your balance?");
            var userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes")
            {                
                Console.WriteLine($"${newAccount.GetBalance()}");
            }
            else
            {
                Console.WriteLine("Well to bad Im still showing you:");
                Console.WriteLine($"${newAccount.GetBalance()}");
            }




        }
    }
}

