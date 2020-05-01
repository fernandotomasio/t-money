using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace t_money.Models
{
    public class BudgetItem
    {
        public Budget Budget { get; set; }
        public Category Category { get; set; }
        public double Amount { get; set; }


    }
}
