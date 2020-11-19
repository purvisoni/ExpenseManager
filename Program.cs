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
                Console.WriteLine("Please enter a command:\n"+
                "c-to add expense;\n" +
                "r-to view expense;\n" +
                "u-to update expense;\n" +
                "d-to delete expense;\n" +
                "l-visited location;\n" +
                "q-quit\n ");

                string userInput=Console.ReadLine();

                if(userInput=="c")
                {
                    Console.WriteLine("How many items you need to add?");
                    String userInput1=Console.ReadLine();
                    int no=Convert.ToInt32(userInput1);
                    Console.WriteLine("Enter each item details in sequence as 1)Storename 2)Itemname 3)Amount 4)Category:");
                    for(int i=0;i<no;i++){
                        var e1=new ExpenseDetail()
                     {
                        ItemId=Guid.NewGuid(),
                        StoreName=Console.ReadLine(),
                        ItemName=Console.ReadLine(),
                        Amount=Convert.ToInt32(Console.ReadLine()),
                      //  ExpenseDate=DateTime.Now,
                        Category=Console.ReadLine()
                     };
                      theExpenseSystem.AddExpense(e1);
                    }
                    
                 // ExpenseDetail expense;
                 
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
