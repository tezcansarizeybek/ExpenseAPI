using ExpenseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseAPI.Data
{
    public class SqlExpenseRepo : IExpenseRepo
    {
        private readonly ExpenseContext _context;

        public SqlExpenseRepo(ExpenseContext context)
        {
            _context = context;
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _context.Expenses.ToList();
        }

        public Expense GetExpenseByUuid(Guid uuid)
        {
            return _context.Expenses.FirstOrDefault(p => p.Uuid.Equals(uuid));
        }
    }
}
