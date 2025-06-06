﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunGroup.Models;

namespace RunGroup.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Race> Races { get; set; }

    public DbSet<Club> Clubs { get; set; }

    public DbSet<Address> Addresses { get; set; }
}



