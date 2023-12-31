﻿using FORMACIM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FORMACIM.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Server=DESKTOP-9ALDN9L;Database=FORMACIM;Integrated Security=true")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}