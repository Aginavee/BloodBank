using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bloodbankapp.Models;

namespace Bloodb.Entity
{
    public class Entitycontext:DbContext
    {
        public Entitycontext(): base("dnte")
        {
          //  Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LoginContext>());
        }
        public DbSet<bloodb.Entity.Donate> Donates { get; set; }
    }
}