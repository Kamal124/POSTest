﻿using Microsoft.EntityFrameworkCore;
using POSTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Size> Size { get; set; }
    }

}
