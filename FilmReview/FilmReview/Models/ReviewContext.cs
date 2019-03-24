﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FilmReview.Models;

namespace FilmReview.Models
{
    public class ReviewContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ReviewContext() : base("name=ReviewContext")
        {
        }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Film> Films { get; set; }
    }
}
