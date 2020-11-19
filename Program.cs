using System;

namespace ExpenseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var theExpenseSystem=new ExpenseSystem();
            Console.WriteLine("Welcome to Expense Manager Application!");

            while(true)
            {
                Console.WriteLine("Please enter a command:c-to add expense; r-to view expense; u-to update expense; d-to delete expense; l-visited location; q-quit ");

                string userInput=Console.ReadLine();

                if(userInput=="c")
                {
                  theExpenseSystem.AddExpense();
                }

                if(userInput=="r")
                {
                  theExpenseSystem.ViewExpense();
                }

                if(userInput=="u")
                {
                  theExpenseSystem.UpdateExpense();;
                }
                if(userInput=="d")
                {
                  theExpenseSystem.DeleteExpense();
                }
                if(userInput=="l")
                {
                    theExpenseSystem.visitedLocation();
                }

                if(userInput=="q")
                {
                    //to quit
                    break;
                }
            }
        }
    }
}
