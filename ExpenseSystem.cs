using System;
using System.Collections.Generic;
namespace ExpenseManager
{
    public class ExpenseSystem
    {
        public ExpenseSystem(IStoreExpense expenseStorage)
        {
          //  _userList=new List<User>();
         // _expenseList=new List<ExpenseDetail>();
         _expenseStorage=expenseStorage;

         _expenseStorage.AddExpense(new ExpenseDetail() {
              ItemId=Guid.NewGuid(),
              StoreName="Superstore",
              ItemName="Milk",
              Amount=4.56,
              ExpenseDate=DateTime.Now,
              Category="Food"
          });

        _expenseStorage.AddExpense(new ExpenseDetail() {
              ItemId=Guid.NewGuid(),
              StoreName="Walmart",
              ItemName="Trouser",
              Amount=11,
              ExpenseDate=DateTime.Now,
              Category="Clothes"
          });
        }

        //storage
        private readonly IStoreExpense _expenseStorage;
       
        public void AddNewExpense(ExpenseDetail newExpense){
            _expenseStorage.AddExpense(newExpense);
            
        }

        public List<ExpenseDetail> ViewAllExpense(){
            return _expenseStorage.ViewExpense();
        }

        public void visitedLocation()
        {
            Console.WriteLine("User visited location..");
        }

    }
}