using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskList.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Task> Tasks { get; set; }
    }

    public class Task
    {
        public int ID { get; set; }
       
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }

        public int UserId { get; set; }
        public User AssignedUser { get; set; }
    }

    public class TaskListContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany<Task>(u => u.Tasks)
                .WithRequired(t => t.AssignedUser)
                .HasForeignKey<int>(t => t.UserId);
        }
    }
}