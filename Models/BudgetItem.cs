using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace t_money.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public double Amount { get; set; }
        public User User { get; set; }


    }
}
