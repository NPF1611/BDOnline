using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BDOnline.Models
{
    public class BDOnlineDB : DbContext
    {
        public BDOnlineDB() : base("BDOnlineDBConnectionString")
        {
        }
        
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Classes> Classess { get; set; }

    }
}