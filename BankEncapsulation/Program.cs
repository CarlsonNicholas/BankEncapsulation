namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

           BankAccount userBank = new BankAccount(0);

            Console.WriteLine("Hello User: How much money would you like to deposit into the account?");
            double moneyIn = double.Parse(Console.ReadLine());


            userBank.Deposit(moneyIn);
            Console.WriteLine($"You have added ${moneyIn} to you account.");

            Console.WriteLine("");

            double addedBalance = userBank.GetBalance();

            Console.WriteLine($"Your new total balance is ${addedBalance}.");

            Console.WriteLine("");

            Console.WriteLine("Would you like to make a withdrawl? (Y/N) ");
            var response = Console.ReadLine();
            if (response == "Y")
            {
                Console.WriteLine("How much money would you like to withdraw?");
                double moneyOut = double.Parse(Console.ReadLine());
                userBank.Withdraw(moneyOut);
                Console.WriteLine($"You have removed ${moneyOut} from your account.");
                Console.WriteLine();

                double removedBalance = userBank.GetBalance();

                Console.WriteLine($"Your new balance is ${removedBalance}: have a great day!");

            }
            else
            { 
                Console.WriteLine("Have a great day!"); 
            }



        }
    }
}
