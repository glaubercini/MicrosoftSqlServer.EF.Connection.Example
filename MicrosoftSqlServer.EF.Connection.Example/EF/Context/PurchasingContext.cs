using Microsoft.EntityFrameworkCore;
using MicrosoftSqlServer.EF.Connection.Example.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSqlServer.EF.Connection.Example.EF.Context
{
    internal class PurchasingContext : DbContext
    {
        private static readonly string Server = "localhost";
        private static readonly string User = "sa";
        private static readonly string DBname = "AdventureWorks2019";
        private static readonly string Password = "blog_6109";

        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(string.Format(
                    "Server={0};User Id={1};Database={2};Password={3};TrustServerCertificate=True",
                    Server,
                    User,
                    DBname,
                    Password));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("purchasing");
            base.OnModelCreating(modelBuilder);
        }
    }
}
