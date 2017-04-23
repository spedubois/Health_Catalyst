using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace people.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<People> People { get; set; }

    }
}