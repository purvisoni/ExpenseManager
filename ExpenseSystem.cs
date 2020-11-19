using System;
using System.Collections.Generic;
namespace ExpenseManager
{
    public class ExpenseSystem
    {
        public ExpenseSystem()
        {
          //  _userList=new List<User>();
          _expenseList=new List<ExpenseDetail>();

          var expense1=new ExpenseDetail() {
              ItemId=Guid.NewGuid(),
              StoreName="Superstore",
              ItemName="Milk",
              Amount=4.56,
              ExpenseDate=DateTime.Now,
              Category="Food"
          };

          var expense2=new ExpenseDetail() {
              ItemId=Guid.NewGuid(),
              StoreName="Walmart",
              ItemName="Trouser",
              Amount=11,
              ExpenseDate=DateTime.Now,
              Category="Clothes"
          };

          _expenseList.Add(expense1);
          _expenseList.Add(expense2);
        }

        //storage
        //private List<User> _userList;
        private List<ExpenseDetail> _expenseList;
        public void AddExpense(ExpenseDetail expense)
        {
            _expenseList.Add(expense);
            Console.WriteLine("Adding an expense...");
        }
        public void ViewExpense()
        {
            Console.WriteLine("Viewing the expense...");
            for (int i=0;i<_expenseList.Count;i++)
            {
                Console.WriteLine(_expenseList[i].ItemName);
            }
        }
        public void UpdateExpense()
        {
            Console.WriteLine("Updating the expense...");
        }
        public void DeleteExpense()
        {
            Console.WriteLine("Deleting the expense...");
        }

        public void visitedLocation()
        {
            Console.WriteLine("User visited location..");
        }

    }
}