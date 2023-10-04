using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bloodbankapp.Models
{
    public class LoginContext:DbContext
    {
        public LoginContext():base("name=bank")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LoginContext>());
        }
        public DbSet<Register>Registers { get; set; }
        public DbSet<Look> Looks { get; set; }
    }
}