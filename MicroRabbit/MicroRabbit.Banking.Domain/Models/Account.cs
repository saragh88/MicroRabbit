﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal AccountBalance { get; set; }
    }

}
