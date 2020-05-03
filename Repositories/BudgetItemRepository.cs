using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMoney.Data;
using TMoney.Models;

namespace TMoney.Repositories
{
    public class BudgetItemRepository : BaseRepository<BudgetItem>, IBudgetItemRepository
    {
        public BudgetItemRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
