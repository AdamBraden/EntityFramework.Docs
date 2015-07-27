﻿using Microsoft.Data.Entity;

namespace EFModeling.Configuring.FluentAPI.Samples.Relational.DataTypeForProvider
{
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(b => b.Url)
                .HasSqlServerColumnType("varchar(200)");
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
}
