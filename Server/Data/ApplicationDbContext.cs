﻿using IncidentesQonecta.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IncidentesQonecta.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<Usuario> Usuarios { get; set; }
    }
}
