using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myChecking = new BankAccount();

            string custAnswer;
            string custAnswerUpper;

            Console.WriteLine("Welcome to Wells Fargo, what would you like to do today?");

            do
            {
                Console.WriteLine("You can write 'Deposit' to deposit money into your account or 'Balance' to get your current total balance.");

                custAnswer = Console.ReadLine();
                
                custAnswerUpper = custAnswer.ToUpper();

                if (custAnswerUpper == "DEPOSIT")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    myChecking.Deposit((Convert.ToDouble(Console.ReadLine())));

                }
                else if (custAnswerUpper == "BALANCE")
                {
                    Console.WriteLine($"Your balance is: {myChecking.GetBalance()}");
                }
                else if (custAnswerUpper != "DONE")
                {
                    Console.WriteLine("That is not a valid response, please try again.");
                }
                else
                {
                    Console.WriteLine("Is there anything else I can help you with?  If not you can put 'Done' if you are finished.");
                }
            } while (custAnswerUpper != "DONE");
            
            
                Console.WriteLine("Thank you, have a nice day!"); 
            
        }
    }
}
