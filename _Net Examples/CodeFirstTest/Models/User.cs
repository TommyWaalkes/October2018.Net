using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstTest.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
    }

    public class UserContext : DbContext
    {
       // List<User> Users { get; set; }

        public DbSet<User> Users { get; set; }
    }
}