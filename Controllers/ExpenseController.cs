using ExpenseAPI.Data;
using ExpenseAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExpenseAPI.Controllers
{
    //Api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseRepo _repository;

        public ExpenseController(IExpenseRepo repository) {
            _repository = repository;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/controller
        [HttpGet]
        public ActionResult<IEnumerable<Expense>> GetAllExpenses() {
            var expenseItems = _repository.GetAllExpenses();
            return Ok(expenseItems);
        }


        //GET api/[controller]/{id}
        [HttpGet("{uuid}")]
        public ActionResult<Expense> GetExpenseByUuid(Guid uuid) {
            var expenseItem = _repository.GetExpenseByUuid(uuid);
            return Ok(expenseItem);
        }
    }
}