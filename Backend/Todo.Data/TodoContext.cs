using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Entities.Todo>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Category)
                    .WithMany()
                    .HasForeignKey(e => e.CategoryId);
            });

            builder.Entity<Entities.Category>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }

        public virtual DbSet<Entities.Category> Categories { get; set; }
        public virtual DbSet<Entities.Todo> Todos { get; set; }
    }
}
