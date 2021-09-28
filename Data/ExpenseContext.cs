using ExpenseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseAPI.Data{
    public class ExpenseContext : DbContext{
        public ExpenseContext(DbContextOptions<ExpenseContext> opt) : base(opt) { }
        public DbSet<Expense> Expenses { get; set; } 
    }
}