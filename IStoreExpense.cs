using System;
using System.Collections.Generic;

namespace ExpenseManager{
    public interface IStoreExpense{

        void AddExpense(ExpenseDetail expense);

        List<ExpenseDetail> ViewExpense();
        void UpdateExpense();
        void DeleteExpense();
    }
}