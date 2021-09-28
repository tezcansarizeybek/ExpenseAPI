using System;
using System.Collections.Generic;
using ExpenseAPI.Models;

namespace ExpenseAPI.Data
{
    public interface IExpenseRepo
    {
        IEnumerable<Expense> GetAllExpenses(); 
        Expense GetExpenseByUuid(Guid uuid);
    }
}