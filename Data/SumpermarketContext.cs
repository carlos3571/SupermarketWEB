﻿using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SumpermarketContext : DbContext
    {

        public SumpermarketContext(DbContextOptions options) : base (options) 
        {
        
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories {  get; set; }    
        public DbSet<PayModes> payModes { get; set; }
        public DbSet<Providers> providers { get; set; }

    }
}
