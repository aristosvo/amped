﻿using Microsoft.EntityFrameworkCore;

namespace Amped.Core;

public class AmpedDbContext : DbContext
{
    public AmpedDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Bookmark> Bookmarks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bookmark>()
            .HasKey(b => new {b.Uri, b.Owner});
    }
}