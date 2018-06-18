﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillService.Models
{
    [Table ("tblBills")]
    public class Bill
    {
        int Id { get; set; }

        [Required]
        DateTime Date { get; set; }

        IEnumerable<string> CounterNames { get; set; }

        [Required]
        int Price { get; set; }

        [Required]
        bool Status { get; set; }

        int UserId { get; set; }

        IEnumerable<int> CounterIds { get; set; }
    }

    public class BillDBContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
    }

}