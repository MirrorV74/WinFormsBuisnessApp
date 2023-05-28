using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBuisnessApp.Models
{
    internal class Outcome
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int Money { get; set; }
    }
}
