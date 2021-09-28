using System;
using System.Collections.Generic;
using ExpenseAPI.Models;

namespace ExpenseAPI.Data
{
    public class MockExpenseRepo : IExpenseRepo
    {
        public IEnumerable<Expense> GetAllExpenses()
        {
            var commands = new List<Expense>
            {
                new Expense {DESCPRIPTION="Boil an Egg",TOTAL=0,DATE="Kettle & Pan",CATEGORY=""},
                new Expense {DESCPRIPTION="Cut bread",TOTAL=255.99,DATE="Chopping Board",CATEGORY=""},
                new Expense {DESCPRIPTION="Make cup of tea",TOTAL=25.60,DATE="Kettle & cup",CATEGORY=""}
            };
            return commands;
        }

        public Expense GetExpenseByUuid(Guid uuid)
        {
            return new Expense { DESCPRIPTION = "Boil an Egg", TOTAL =12.95, DATE = "Kettle & Pan", CATEGORY = "" };
        }
    }
}