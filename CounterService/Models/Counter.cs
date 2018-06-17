﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CounterService.Models
{
    [Table ("tblCounters")]
    public class Counter
    {
        public int Id { get; set; }
        [Required]
        public int val { get; set; }

        public int UserId { get; set; }
    }

    public class CounterDBContext : DbContext
    {
        public DbSet<Counter> Counters { get; set; }
    }
}