using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t_money.Data;
using t_money.Models;

namespace t_money.Repositories
{
    public class BudgetItemRepository : BaseRepository<BudgetItem>, IBudgetItemRepository
    {
        public BudgetItemRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
