﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SumpermarketContext : DbContext
    {

        public SumpermarketContext(DbContextOptions options) : base (options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<PayMode> PayModes { get; set; }


    }
}
