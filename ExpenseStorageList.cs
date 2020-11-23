using System;
using System.Collections.Generic;

namespace ExpenseManager{

    public class ExpenseStorageList : IStoreExpense{

        private readonly List<ExpenseDetail> _expenseList;
        public ExpenseStorageList(){
            _expenseList=new List<ExpenseDetail>();
        }

        public void AddExpense(ExpenseDetail expense){
            _expenseList.Add(expense);
            Console.WriteLine("Expense has been added sucessfully!!!");
        }

        public List<ExpenseDetail> ViewExpense(){
            return _expenseList;
        }

        public void UpdateExpense(){
            Console.WriteLine("Updating the expense...");

        }
        public void DeleteExpense(){
            Console.WriteLine("Deleting the expense...");

        }
    

    }
}