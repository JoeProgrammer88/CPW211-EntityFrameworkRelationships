﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_EntityFrameworkRelationships
{
    internal class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with VS
            // Trusted_Connection - indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFRelationships;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}