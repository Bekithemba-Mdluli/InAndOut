using InAndOut.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace InAndOut.Controllers
{
    internal class ExpenseVm
    {
        public Expense Expense { get; internal set; }
        public IQueryable<SelectListItem> TypeDropDown { get; internal set; }
    }
}