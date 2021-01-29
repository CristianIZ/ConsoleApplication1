﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LC.Domain;

namespace LC.Context
{
    public class LcContext : DbContext
    {
        public LcContext() : base(@"Server=HXNB-ZAPPALA\SQLEXPRESS;Database=LC;Integrated Security=True;")
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Files> Files { get; set; }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
