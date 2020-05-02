using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace t_money.Models
{
    public class Transaction: BaseModel
    {
        public TransactionType TransactionType { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

    }
}
