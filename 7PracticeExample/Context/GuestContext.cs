using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _7PracticeExample.Entities;

namespace _7PracticeExample.Context
{
    public class GuestContext : DbContext
    {
        public GuestContext()
            : base("GuestContext")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Guest> Guests { get; set; }
    }
}

