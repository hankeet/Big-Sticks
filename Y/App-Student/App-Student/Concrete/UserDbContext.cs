using Student.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace App_Student.Concrete
{
    public class UserDbContext:Context
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public UserDbContext() 
            : base("DefaultConnection") { }

        
    }
}