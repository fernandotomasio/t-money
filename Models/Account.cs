﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMoney.Models
{
    public class Account : BaseModel
    {
        public AccountType AccountType { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}
